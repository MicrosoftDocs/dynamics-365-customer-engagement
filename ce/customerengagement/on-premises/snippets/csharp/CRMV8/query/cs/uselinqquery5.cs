// <snippetuselinqquery5>


 Contact benAndrews = svcContext.ContactSet.Where(c => c.FullName == "Ben Andrews").FirstOrDefault();
 if (benAndrews != null)
 {
  //benAndrews.Contact_Tasks is null until LoadProperty is used.
  svcContext.LoadProperty(benAndrews, "Contact_Tasks");
  Task benAndrewsFirstTask = benAndrews.Contact_Tasks.FirstOrDefault();
  if (benAndrewsFirstTask != null)
  {
   Console.WriteLine("Ben Andrews first task with Subject: '{0}' retrieved.", benAndrewsFirstTask.Subject);
  }
 }

// </snippetuselinqquery5>