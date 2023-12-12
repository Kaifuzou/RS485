bool slave = true;
bool ok = false;
String st = "";
String startflag = "";
String sender = "";
String receiver = "";
String cmd = "";
String data = "";
String stopflag = "";
#define signall 2

void setup() {
  for (int i = 10; i < 14; i++) {
    pinMode(i, OUTPUT);
  }
  pinMode(signall, OUTPUT);
  delay(10);
  digitalWrite(signall, LOW);
  Serial.begin(9600);
  pinMode(4, INPUT);
  delay(10);
  if(digitalRead(4) == HIGH){
    slave = true;
  }
  else{
    slave = false;
  }
  delay(10);
}

void ledon(int i, String st) {
  digitalWrite(i + 9, HIGH);
  delay(10);
  digitalWrite(signall, HIGH);
  Serial.println(st);
  delay(10);
  digitalWrite(signall, LOW);
  delay(10);
}

void ledoff(int i, String st) {
  digitalWrite(i + 9, LOW);
  delay(10);
  digitalWrite(signall, HIGH);
  Serial.println(st);
  delay(10);
  digitalWrite(signall, LOW);
  delay(10);
}

void reset(bool slave, String st){
  if (st == "Reset") {
        if (slave == true) {
          for (int i = 1; i <= 4; i++) {
            digitalWrite(9 + i, LOW);
            digitalWrite(signall,HIGH);
            Serial.println("@01T" + String(i) + "#");
            delay(10);
            digitalWrite(signall,LOW);
            delay(10);
          }
        } 
        else if (slave == false) {
          delay(50);
          for (int i = 1; i <= 4; i++) {
            digitalWrite(9 + i, LOW);
            digitalWrite(signall,HIGH);
            Serial.println("@02T" + String(i) + "#");
            delay(10);
            digitalWrite(signall,LOW);
            delay(10);
          }
        }
  }
}

void check(bool slave, String st){
  if(slave == true && st == "Check"){
    digitalWrite(signall,HIGH);
    Serial.println("ON1");
    digitalWrite(signall,LOW);
  }
  if(slave == false && st == "Check"){
    delay(20);
    digitalWrite(signall,HIGH);
    Serial.println("ON2");
    digitalWrite(signall,LOW);
  }
}

void loop() {
  while (Serial.available() > 0) {
    char c = Serial.read();
    st += c;
    delay(2);
    ok = true;
  }

  if(ok == true){
    st.trim();
    startflag = st.substring(0, 1);
    sender = st.substring(1, 2);
    receiver = st.substring(2, 3);
    cmd = st.substring(3, 4);

    int leng = st.length();
    int a = leng - 1;
    data = st.substring(4, a);
    stopflag = st.substring(a, leng);
    int intdata = data.toInt();
    
    if (startflag == "@" && stopflag == "#") {
      if (slave == true && receiver == "1") {
        if (cmd == "B") {
          ledon(intdata, st);
        } else if (cmd == "T") {
          ledoff(intdata, st);
        }
      } else if (slave == false && receiver == "2") {
        if (cmd == "B") {
          ledon(intdata, st);
        } else if (cmd == "T") {
          ledoff(intdata, st);
        }
      }
    }
    reset(slave,st);
    check(slave,st);
    st = "";
    ok = false;
  }
}