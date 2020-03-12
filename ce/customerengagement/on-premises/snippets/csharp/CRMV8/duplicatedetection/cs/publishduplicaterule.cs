// <snippetpublishduplicaterule>


 // Retrieve all rules for the entity
 var rules = _serviceProxy.RetrieveMultiple(
     new QueryByAttribute(DuplicateRule.EntityLogicalName)
 {
     ColumnSet = new ColumnSet("duplicateruleid"),
     Attributes = { "matchingentityname" },
     Values = { entityName }
 });

 List<Guid> crmAsyncOperationIds = new List<Guid>();
 foreach (var item in rules.Entities)
 {
     Console.WriteLine(String.Concat("Publishing duplicate rule: ", item.Id));

     // Publish each rule and get the job id since it is async
     var response = (PublishDuplicateRuleResponse)_serviceProxy.Execute(
             new PublishDuplicateRuleRequest { DuplicateRuleId = item.Id });

     crmAsyncOperationIds.Add(response.JobId);
 }

// </snippetpublishduplicaterule>