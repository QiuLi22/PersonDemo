// See https://aka.ms/new-console-template for more information

// Qiu Li 5-26-2022  

using PersonDemo;

Person personA = new Person();
personA.FirstName = "Qiu";
personA.LastName = "Li";
personA.Email = "qiuli@stmc.edu";

Person personB = new Person();
personB.FirstName = "Raque";
personB.LastName = "Li";
personB.Email = "r.Li@stmc.edu";

Person personC = new Person();
personC.FirstName = "Charley";
personC.LastName = "Li";
personC.Email = "charley.li@stmc.edu";

personA.DisplayName();
personA.DisplayEmail();
personB.DisplayName();
personB.DisplayEmail();
personC.DisplayName();
personC.DisplayEmail();





