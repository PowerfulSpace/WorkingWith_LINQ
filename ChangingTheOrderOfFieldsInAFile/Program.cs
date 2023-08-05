



string[] lines = File.ReadAllLines(@"D:\Testing\Test3.txt");

IEnumerable<string> query =
            from line in lines
            let x = line.Split(',')
            orderby x[2]
            select x[2] + ", " + (x[1] + " " + x[0]);


File.WriteAllLines(@"D:\Testing\Test4.txt", query);


Console.ReadLine();


//Данные в файле

//Adams,Terry,120
//Fakhouri,Fadi,116
//Feng,Hanying,117
//Garcia,Cesar,114
//Garcia,Debra,115
//Garcia,Hugo,118
//Mortensen,Sven,113
//O 'Donnell,Claire,112  
//Omelchenko,Svetlana,111
//Tucker,Lance,119
//Tucker,Michael,122
//Zabokritski,Eugene,121  



//Данные в файле после запроса

//111, Svetlana Omelchenko  
//112, Claire O'Donnell  
//113, Sven Mortensen  
//114, Cesar Garcia  
//115, Debra Garcia  
//116, Fadi Fakhouri  
//117, Hanying Feng  
//118, Hugo Garcia  
//119, Lance Tucker  
//120, Terry Adams  
//121, Eugene Zabokritski  
//122, Michael Tucker 