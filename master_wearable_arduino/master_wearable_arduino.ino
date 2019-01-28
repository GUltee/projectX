#include <Wire.h>
#include <SPI.h>
#include <WiFiNINA.h>
char ssid[] = "your ID";              // your network SSID (name)
char pass[] = "your password";        // your network password (use for WPA, or use as key for WEP)

int status = WL_IDLE_STATUS;
char server[] = "your server";
const int GSR = A1;
int sensorValue = 0;
int gsr_average = 0;
char heart_rate = 0;

WiFiClient client;

void setup() {
  Serial.begin(9600);
  Wire.begin();
  pinMode(9, OUTPUT);
  pinMode(10, OUTPUT);
  digitalWrite(9, HIGH);
  digitalWrite(10, LOW);

  while (status != WL_CONNECTED) {
    Serial.print("Attempting to connect to SSID: ");
    Serial.println(ssid);

    // Connect to WPA/WPA2 network. Change this line if using open or WEP network:
    status = WiFi.begin(ssid, pass);

    // wait 1 second for connection:
    delay(1000);
  }
}

void loop() {
  long sum = 0;

  Wire.requestFrom(0xA0 >> 1, 1);    // request 1 bytes from slave device
  while (Wire.available()) {         // slave may send less than requested
    unsigned char c = Wire.read();   // receive heart rate value (a byte)
    Serial.print(c, DEC);            // print heart rate value
    heart_rate = c;
    Serial.print("\t");
  }

  for (int i = 0; i < 10; i++)       //Average the 10 measurements to remove the glitch
  {
    sensorValue = analogRead(GSR);
    sum += sensorValue;
    delay(5);
  }

  gsr_average = sum / 10;
  Serial.println(gsr_average);

  if (client.connect(server, 80)) {
    Serial.println("connected to server");

    // Make a HTTP request:
    //change tableName to your own database table name
    client.println("GET tableName.php?heart_rate=" + String(heart_rate, DEC) + "&gsr=" + String(gsr_average, DEC) + " HTTP/1.1");
    client.println("Host: host name");
    client.println("Connection: Close");
    client.println();
  }

  delay(1000);
}
