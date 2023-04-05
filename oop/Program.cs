using oop;

//Prob1 obj = new Prob1();

//obj.city = "dhaka";



Jet myJet = new Jet();
Airplane myAirplane = myJet; // Upcasting


Airplane myAirplane2 = new Jet();
Jet myJet2 = (Jet)myAirplane2; // Downcasting
myJet2.Afterburner();