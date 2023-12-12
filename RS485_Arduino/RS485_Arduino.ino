int Led1 = 10;
int Led2 = 11;
int Led3 = 12;
int Led4 = 13;
int signall = 2;
String add = "";

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
  add = digitalRead(4) == 1 ? "SL1" : "SL2";
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

void loop() {
  String st = "";
  String startflag = "";
  String sender = "";
  String receiver = "";
  String cmd = "";
  String data = "";
  String stopflag = "";

  while (Serial.available() > 0) {
    char c = Serial.read();
    st += c;
    delay(2);
  }

  st.trim();
  if (st != "") {
    startflag = st.substring(0, 1);
    sender = st.substring(1, 2);
    receiver = st.substring(2, 3);
    cmd = st.substring(3, 4);

    int leng = st.length();
    int a = leng - 1;
    data = st.substring(4, a);
    stopflag = st.substring(a, leng);

    int intdata = data.toInt();

    if (st == "Reset") {
      if (add == "SL1") {
        for (int i = 1; i <= 4; i++) {
          digitalWrite(9 + i, LOW);
          Serial.println("@01T" + String(i) + "#");
          delay(10);
        }
      } else if (add == "SL2") {
        for (int i = 1; i <= 4; i++) {
          delay(50);
          digitalWrite(9 + i, LOW);
          Serial.println("@02T" + String(i) + "#");
          delay(10);
        }
      }
    }

    if (st == "Check") {
      Serial.println("ON" + add);
    }
    
    if (startflag == "@" && stopflag == "#") {
      if (add == "SL1" && receiver == "1") {
        if (cmd == "B") {
          ledon(intdata, st);
        } else if (cmd == "T") {
          ledoff(intdata, st);
        }
      } else if (add == "SL2" && receiver == "2") {
        if (cmd == "B") {
          ledon(intdata, st);
        } else if (cmd == "T") {
          ledoff(intdata, st);
        }
      }
    }
  }
}
// print
