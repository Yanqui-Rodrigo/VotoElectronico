
int ct = 15;    //calibration time
int pirPin = 2;    //PIR sensor's output
int ledPin = 13;
int buzzerPin = 10;
int encendido=0;
 
void setup(){
  Serial.begin(9600);
  pinMode(pirPin, INPUT);
  pinMode(ledPin, OUTPUT);
  pinMode(buzzerPin, OUTPUT);
  digitalWrite(pirPin, LOW);
  digitalWrite(ledPin, LOW);
  digitalWrite(buzzerPin, LOW);
   
  Serial.println("Espere, ahora calibrando el sensor....");
    for(int i = 0; i <= ct; i++){
      Serial.print(((i*100)/ct));
      Serial.print("% ");
      Serial.println("COMPLETADO.....");
      delay(50);
      }
    Serial.println("Calibracion Completada Satisfactoriamente.");
    Serial.println("** SENSOR ACTIVO **");
    delay(50);
  }
 
void loop()
{
  if (Serial.available()>0)
  {
    int option = Serial.read();
    if(option == 'a')
    {
      if(digitalRead(pirPin) == HIGH)
     {
       encendido=1;
       digitalWrite(ledPin, HIGH);
       digitalWrite(buzzerPin, HIGH);
       //Serial.println("------------------------");
       Serial.println(encendido);
       //Serial.println("------------------------");
       //Serial.println("");
       delay(1000);   
     }
    }
    if(option == 'b')
    {
      digitalWrite(pirPin, LOW);
      digitalWrite(ledPin, LOW); 
      digitalWrite(buzzerPin, LOW);
    }
  }    
}
