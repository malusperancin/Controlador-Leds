int on;
int c;
int pisca;
int i;
void setup() 
{
  Serial.begin(19200); //inicia comunicação serial com 9600 
   pinMode(2, OUTPUT);
   pinMode(3, OUTPUT);
   pinMode(4, OUTPUT);
   pinMode(5, OUTPUT);
   pinMode(6, OUTPUT);
   pinMode(7, OUTPUT);
   pinMode(8, OUTPUT);
   pinMode(9, OUTPUT);
} 
void loop()
{ 
  if(Serial.available() > 0) //se algum dado disponível 
{
 char c = Serial.read(); //le o byte disponível



if (c == 'q') //PRIMEIRO EFEITO
{
  on = 200;
  pisca = 0;
  while (pisca <= 20)
{
    digitalWrite(3, HIGH); 
    digitalWrite(5, HIGH); 
    digitalWrite(7, HIGH); 
    digitalWrite(9, HIGH); 
    delay(on);              
    digitalWrite(3, LOW); 
    digitalWrite(5, LOW); 
    digitalWrite(7, LOW); 
    digitalWrite(9, LOW); 
    delay(0);
    digitalWrite(2, HIGH); 
    digitalWrite(4, HIGH); 
    digitalWrite(6, HIGH); 
    digitalWrite(8, HIGH);   
    delay(on);              
    digitalWrite(2, LOW); 
    digitalWrite(4, LOW); 
    digitalWrite(6, LOW); 
    digitalWrite(8, LOW);  
    delay(0);     
      
   pisca +=1;

    if (on >= 10)
    on -= 10;
}
Serial.print("s"); //ENVIA S QUANDO ACABA O EFEITO
}

    
if (c == 'w') //SEGUNDO EFEITO
{

for (int i = 2; i <= 9; i++)
{
digitalWrite(i, HIGH);
delay(20); 
digitalWrite(i, LOW); 
  
  }
   for (int i = 8; i >= 1; i--)
{
digitalWrite(i, HIGH);
delay(80); 
digitalWrite(i, LOW); 
} 
Serial.print("s"); //ENVIA S QUANDO ACABA O EFEITO
}


if (c == 'e') //TERCEIRO EFEITO
{
  for (int i = 9; i >= 1; i--)
{
  if (i % 2 == 0)
  {
digitalWrite(i, HIGH);
delay(100); 
digitalWrite(i, LOW); 
 }
} 
for (int i = 1; i <= 9; i++)
{
 if (i % 2 != 0)
  {
digitalWrite(i, HIGH);
delay(100); 
digitalWrite(i, LOW); 
  }
} 
Serial.print("s"); //ENVIA S QUANDO ACABA O EFEITO
}


if (c == 'r') //QUARTO EFEITO
{
  for(int i = 9; i >= 2; i--)
{
      digitalWrite(9 - i,HIGH);
    delay(80);
    digitalWrite(i + 1, HIGH);
}
    for(int i = 9; i >= 2; i--)
{
      digitalWrite(9 - i,LOW);
    delay(80);
    digitalWrite(i + 1, LOW);
}
Serial.print("s"); //ENVIA S QUANDO ACABA O EFEITO
}


if (c == 't') //QUINTO EFEITO
{
 
  int i = 0;
  for (int i = 9; i >= 1; i--)
{
  if (i % 2 == 0)
  {
digitalWrite(i, HIGH);
delay(100); 
digitalWrite(i, LOW); 
  }
} 
 for (int i = 9; i >= 1; i--)
{
  if (i % 2 != 0)
  {
digitalWrite(i, HIGH);
delay(100); 
digitalWrite(i, LOW); 
  }
} 
Serial.print("s"); //ENVIA S QUANDO ACABA O EFEITO
}
}
}





    
  
  

