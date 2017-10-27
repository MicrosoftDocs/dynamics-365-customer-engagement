// <snippetmerge1>


          // Create the target for the request.
 EntityReference target = new EntityReference();

 // Id is the GUID of the account that is being merged into.
          // LogicalName is the type of the entity being merged to, as a string
 target.Id = _account1Id;
          target.LogicalName = Account.EntityLogicalName;

          // Create the request.
          MergeRequest merge = new MergeRequest();
          // SubordinateId is the GUID of the account merging.
          merge.SubordinateId = _account2Id;
          merge.Target = target;
          merge.PerformParentingChecks = false;

          Console.WriteLine("\nMerging account2 into account1 and adding " +
              "\"test\" as Address 1 Line 1");

          // Create another account to hold new data to merge into the entity.
          // If you use the subordinate account object, its data will be merged.
          Account updateContent = new Account();
          updateContent.Address1_Line1 = "test";

          // Set the content you want updated on the merged account
          merge.UpdateContent = updateContent;

          // Execute the request.
          MergeResponse merged = (MergeResponse)_serviceProxy.Execute(merge);

// </snippetmerge1>