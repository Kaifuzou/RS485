Arduino:
PIN 10 -> 13 cho 4 con led
PIN 2 cho chân tín hiệu của RS485
PIN 4 cấp nguồn 5v vào PIN 4 ( duy nhất 1 arduino, arduino còn lại không cần)

RS485: R0 -> PIN RX
DI -> PIN TX
VCC - > PIN 5V
GND -> PIN GND
DE ->RE -> PIN 2

Flag:
@01B1# ->@ (Start flag), 0 (Master), 1 (slave 1), B (ON),1 (Led[1,2,3,4]),# (Stop flag)
@01T1# ->@ (Start flag), 0 (Master), 1 (slave 1), T (OFF),1 (Led[1,2,3,4]),# (Stop flag)
@02B1# ->@ (Start flag), 0 (Master), 2 (slave 2), B (ON),1 (Led[1,2,3,4]),# (Stop flag)
@02T1# ->@ (Start flag), 0 (Master), 2 (slave 2), T (OFF),1 (Led[1,2,3,4]),# (Stop flag)