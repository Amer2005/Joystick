#define joyX A0
#define joyY A2

int minPress = 300;

int sw_pin = 2;

int defaultValue = 506;

char forwardKey = 'W';
char backwardKey = 'S';
char leftKey = 'A';
char rightKey = 'D';

void setup() {
  pinMode(sw_pin, INPUT);
  digitalWrite(sw_pin, HIGH);
  Serial.begin(9600);
}
/*
String toString(int a)
{
  String str = "";
  do
  {
    str = (a % 10) str;
  }
  while(a != 0);
}
*/
void loop() {
  // put your main code here, to run repeatedly:
  
  int xValue = analogRead(joyX);  
  int yValue = analogRead(joyY);
 /*
  //print the values with to plot or view

  Serial.print(xValue);
  Serial.print("<");
  Serial.flush();
  delay(50);
  
*/
  if(defaultValue - minPress >= xValue)
  {
     Serial.write(1);
     Serial.flush();
     delay(10);
  }

  if(defaultValue + minPress <= xValue)
  {
     Serial.write(2);
     Serial.flush();
     delay(10);
  }

  if(defaultValue - minPress >= yValue)
  {
     Serial.write(3);
     Serial.flush();
     delay(10);
  }

  if(defaultValue + minPress <= yValue)
  {
     Serial.write(4);
     Serial.flush();
     delay(10);
  }

  if(digitalRead(sw_pin) == 0)
  {
    Serial.write(5);
    Serial.flush();
    delay(120);
  }
  
  
  //Serial.print(xValue);
  //Serial.print("\t");
  //Serial.println(yValue);
}
