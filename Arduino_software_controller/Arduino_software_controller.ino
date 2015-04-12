
//Include servo library
#include <Servo.h> 

/*
byte array:
  0. Vooruit
  1. Achteruit
  2. Links
  3. Rechts
  4. Lichten
  5. Servo
*/
byte Input[6]; //aanmaken van byte array met 6 bytes

//declareren en initialiseren van motor uitgang variabelen
int M1A = 3;
int M1B = 5;
int M2A = 6;
int M2B = 10;

//aanmaken servo object "myservo"
Servo myservo;

//declareren positie van servo standaard is 0°
int Spos = 0;

//declareren en initialiseren van lichten uitgang variabelen
int Voorlicht = 13; //Voorlicht op pin 13
int Achterlicht = 12; //Achterlicht op pin 12


//start van de Setup lus
void setup() {
  //starten van seriele verbinding met baud rate van 9600
  Serial.begin(9600);
  
  //lichten als uitgang definieren
  pinMode(Voorlicht, OUTPUT);  //Voorlicht als uitgang
  pinMode(Achterlicht, OUTPUT); //Achterlicht als uitgang
  
  //standaard alle lichten uit
  digitalWrite(Voorlicht, LOW);
  digitalWrite(Achterlicht, LOW);
  
  //"myservo" object toekenen aan pin 9
  myservo.attach(9);
  
  //motors toekenen als uitgang
  pinMode(M1A, OUTPUT);
  pinMode(M1B, OUTPUT);
  pinMode(M2A, OUTPUT);
  pinMode(M2B, OUTPUT);
  
  //standaard bij opstart motoren uit!
  digitalWrite(M1A, LOW);
  digitalWrite(M1B, LOW);
  digitalWrite(M2A, LOW);
  digitalWrite(M2B, LOW);
  analogWrite(M1A, 0);
  analogWrite(M1B, 0);
  analogWrite(M2A, 0);
  analogWrite(M2B, 0);
}
//einde van de Setup lus


//starten van de Loop lus
void loop() {
  // kijken of er seriele communicatie is?
  if(Serial.available()){
    //Als er seriele communicatie is:
    //lezen van de seriele input (6bytes 0->5)
    Serial.readBytes(Input, 6); //6 staat voor 6bytes; Input staat voor de array variabele
    
    //sturen van de motors
    //de controlles diennen voor analogWrite niet werkt door Servo library
    //sturen van motor M1A
    if (Input[0] == 255){
      analogWrite(M1A, 0); // M1A Analoog op 0
      digitalWrite(M1A, HIGH); // M1A HIGH
    }
    else{
      digitalWrite(M1A, LOW); // M1A LOW
      analogWrite(M1A, Input[0]); //sturen M1A Analoog
    }
    
    //sturen van motor M1B
    if (Input[1] == 255){
      analogWrite(M1B, 0); // M1B Analoog op 0
      digitalWrite(M1B, HIGH); // M1B HIGH
    }
    else{
      digitalWrite(M1B, LOW); // M1B LOW
      analogWrite(M1B, Input[1]); //sturen M1B Analoog
    }
    
    //sturen van motor M2A
    if (Input[2] == 255){
      analogWrite(M2A, 0); // M2A Analoog op 0
      digitalWrite(M2A, HIGH); // M2A HIGH
    }
    else{
      digitalWrite(M2A, LOW); // M2A LOW
      analogWrite(M2A, Input[2]); //sturen M2A Analoog
    }
    
    //sturen van motor M2B
    if (Input[3] == 255){
      analogWrite(M2B, 0); // M2B Analoog op 0
      digitalWrite(M2B, HIGH); // M2B HIGH
    }
    else{
      digitalWrite(M2B, LOW); // M2B LOW
      analogWrite(M2B, Input[3]); //sturen M2B Analoog
    }
    
    //sturen van de led's
    //controlleren van Input[4]
    if (Input[4] == 0){
      //alle lampen UIT!
      digitalWrite(Voorlicht, LOW);
      digitalWrite(Achterlicht, LOW);
    }
    else if (Input[4] == 1){
      //Voorlicht AAN, Achterlicht UIT
      digitalWrite(Voorlicht, HIGH);
      digitalWrite(Achterlicht, LOW);
    }
    else if (Input[4] == 2){
      //Voorlicht UIT, Achterlicht AAN
      digitalWrite(Voorlicht, LOW);
      digitalWrite(Achterlicht, HIGH);
    }
    else if (Input[4] == 3){
      //alle lampen AAN!
      digitalWrite(Voorlicht, HIGH);
      digitalWrite(Achterlicht, HIGH);
    }
      
    //einde controlle lampen
    
    //controlleren van servo ingang
    if (Input[5] > 180){
      //indien hoek groter is dan 180° wordt de servo op 180°geplaatst
      Spos = 180;
    }
    else{
      //indien de hoek niet groter is dan 180° wordt de ingang[5] gebruikt als hoek
      Spos = Input[5];
    }
    //einde controlleren van de servo uitgang
    
    //sturen van de servo
    myservo.write(Spos); //voor waarde Spos zie controlle hierboven
  }
  // einde kijken of er seriele communicatie is?
}
//einde van de Loop lus
