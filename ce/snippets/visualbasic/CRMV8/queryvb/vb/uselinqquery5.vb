' <snippetuselinqquery5>


 Dim benAndrews As Contact = (From c In svcContext.ContactSet
                             Where c.FullName.Equals("Ben Andrews")).FirstOrDefault()
 If benAndrews IsNot Nothing Then
     'benAndrews.Contact_Tasks is null until LoadProperty is used.
     svcContext.LoadProperty(benAndrews, "Contact_Tasks")
     Dim benAndrewsFirstTask As Task = benAndrews.Contact_Tasks.FirstOrDefault()
     If benAndrewsFirstTask IsNot Nothing Then
         Console.WriteLine("Ben Andrews first task with Subject: '{0}' retrieved.",
                           benAndrewsFirstTask.Subject)
     End If
 End If

' </snippetuselinqquery5>