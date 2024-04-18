String data;

int led01 = 8;
int led02 = 7;
int led03 = 2;

int userChoice;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(led01, OUTPUT);
  pinMode(led02, OUTPUT);
  pinMode(led03, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  if(Serial.available()){
      data = Serial.readString();
      blueLED();
      yellowLED();
      redLED();
  }
}
void blueLED(){
  if(data == "blueON"){
          digitalWrite(led01, HIGH);
          digitalWrite(led02, LOW);
          digitalWrite(led03, LOW);
  }
  else if(data == "blueOFF"){
      digitalWrite(led01, LOW);
      digitalWrite(led02, LOW);
      digitalWrite(led03, LOW);
  }
}

void yellowLED(){
  if(data == "yellowON"){
          digitalWrite(led01, LOW);
          digitalWrite(led02, HIGH);
          digitalWrite(led03, LOW);
  }
  else if(data == "yellowOFF"){
      digitalWrite(led01, LOW);
      digitalWrite(led02, LOW);
      digitalWrite(led03, LOW);
  }
}

// 
void redLED(){
  if(data == "redON"){
          digitalWrite(led01, LOW);
          digitalWrite(led02, LOW);
          digitalWrite(led03, HIGH);
  }
  else if(data == "redOFF"){
      digitalWrite(led01, LOW);
      digitalWrite(led02, LOW);
      digitalWrite(led03, LOW);
  }
}
