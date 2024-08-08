

using PatikaWeek4PracticeAbstraction;

// Creating an instance of Worker class
BaseWorker worker1 = new Worker("Bilal", "Bilin", "Proje Geliştirme", "Geliştirici");

// Calling the method for worker1 to print informations
worker1.Gorev();

// Creating an instance of Worker class
Worker worker2 = new Worker();
worker2.Name = "Mikail";
worker2.Surname = "Aslan";
worker2.Department = "Kültür ve Sanat";
worker2.Position = "Besteci";

// Calling the method for worker2
worker2.Gorev();