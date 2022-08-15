// <snippetcreateandassociatekbrecordtoincident1>


 // Create a knowledge base record instance        
 KnowledgeBaseRecord kbRecord = new KnowledgeBaseRecord
 {
     // These are sample values. Replace them with
     // appropriate values as per your integrated 
     // Parature  instance.
     PrivateUrl = "https://www.demo.parature.com/internal",
     PublicUrl = "https://www.demo.parature.com",
     Title = "How to track shipping?",
     UniqueId = "8000/8467/Article/23782"
 };
 _kbRecordId = _serviceProxy.Create(kbRecord);
 Console.WriteLine("Created knowledge base record with ID: '{0}'.\n", _kbRecordId.ToString());

// </snippetcreateandassociatekbrecordtoincident1>