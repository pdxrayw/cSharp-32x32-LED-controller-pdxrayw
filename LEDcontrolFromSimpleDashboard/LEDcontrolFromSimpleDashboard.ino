
//#include "signalsEnum.h"

 enum signalsEnum {
      r0 = A0,
      g0 = 8,
      b0 = A1,
      r1 = 2,
      g1 = 9,
      b1 = 3,
      A = 4,
      B = 10,
      C = 5,
      D = 11,
      stb = 12,
      clk = 6,
      OE = 7
};

void setup() {
     pinMode(A0, OUTPUT); 
     pinMode(g0, OUTPUT); 
     pinMode(A1, OUTPUT); 
     pinMode(r1, OUTPUT); 
     pinMode(g1, OUTPUT); 
     pinMode(b1, OUTPUT); 
     pinMode(A, OUTPUT); 
     pinMode(B, OUTPUT); 
     pinMode(C, OUTPUT); 
     pinMode(D, OUTPUT); 
     pinMode(stb, OUTPUT); 
     pinMode(clk, OUTPUT); 
     pinMode(OE, OUTPUT); 
     //Start with everything off
     digitalWrite(r0, LOW); 
     digitalWrite(g0, LOW); 
     digitalWrite(b0, LOW); 
     digitalWrite(r1, LOW); 
     digitalWrite(g1, LOW); 
     digitalWrite(b1, LOW); 
     digitalWrite(A, LOW); 
     digitalWrite(B, LOW); 
     digitalWrite(C, LOW); 
     digitalWrite(D, LOW); 
     digitalWrite(stb, LOW); 
     digitalWrite(clk, LOW); 
     digitalWrite(OE, HIGH);
     //read serial baud set to 9600, must match in gui
     Serial.begin(9600); // set serial speed
     //pinMode(ledPin13, OUTPUT); // set LED as output
     //digitalWrite(ledPin13, LOW); //turn off LED
}

   
//variable declarations
enum isActiveEnum {
     High = 1,
     Low = 0 
};
  
int pinState;

isActiveEnum isActive = Low;
String strSignal;

int pin;

void loop(){
     while (Serial.available() == 0); // do nothing if nothing sent
  
     strSignal = ""; //initialize to null for next round.

     while (Serial.available()){ 
          delay(3);
          char val = Serial.read(); // deduct ascii value of '0' to find numeric value of sent number
          strSignal += val;
     }//end while
     
     pin = get_signal(strSignal);//get the pin number from the string representation
     pinState = digitalRead(pin);//find state of the pin
     
     //the following code just toggles the signal high or low  
     if (pinState == Low){// if low make the pin high//<<----change is active to pinState to pin
          digitalWrite(pin, HIGH); // turn on pin     
          Serial.println(strSignal + " High pin " + pin);
          //pinState = High;//delete this for production
     }else //it was high make it low
     {
          Serial.println(strSignal + " Low pin " + pin);
          digitalWrite(pin, LOW);  //<<----change pin13 to pin
          //isActive = Low;//delete this for production
     }//end if/else for pin toggle
  

     Serial.flush(); // clear serial port
}//end function loop();


int get_signal(String signal){
     if (signal =="r0") 
         return r0;
         
     if (signal =="g0") 
         return g0;
         
     if (signal =="b0") 
         return b0;
         
     if (signal =="r1") 
         return r1;
         
     if (signal =="g1") 
         return g1;
         
     if (signal =="b1") 
         return b1;
         
     if (signal =="A") 
         return A;
         
     if (signal =="B") 
         return B;
         
     if (signal =="C") 
         return C;
         
     if (signal =="D") 
         return D;
         
     if (signal =="stb") 
         return stb;
         
     if (signal =="clk") 
         return clk;
         
     if (signal =="OE") 
         return OE;               
}//end function get signal
   


