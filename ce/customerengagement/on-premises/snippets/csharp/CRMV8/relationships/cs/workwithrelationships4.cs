// <snippetworkwithrelationships4>


 /// <summary>
 /// Determines whether two entities are eligible to participate in a relationship
 /// </summary>
 /// <param name="referencedEntity">Primary Entity</param>
 /// <param name="referencingEntity">Referencing Entity</param>
 /// <returns></returns>
 public bool EligibleCreateOneToManyRelationship(string referencedEntity, 
     string referencingEntity)
 {
     //Checks whether the specified entity can be the primary entity in one-to-many
     //relationship.
     CanBeReferencedRequest canBeReferencedRequest = new CanBeReferencedRequest
     {
         EntityName = referencedEntity
     };

     CanBeReferencedResponse canBeReferencedResponse =
         (CanBeReferencedResponse)_serviceProxy.Execute(canBeReferencedRequest);

     if (!canBeReferencedResponse.CanBeReferenced)
     {
         Console.WriteLine(
             "Entity {0} can't be the primary entity in this one-to-many relationship", 
             referencedEntity);
     }

     //Checks whether the specified entity can be the referencing entity in one-to-many
     //relationship.
     CanBeReferencingRequest canBereferencingRequest = new CanBeReferencingRequest
     {
         EntityName = referencingEntity
     };

     CanBeReferencingResponse canBeReferencingResponse =
         (CanBeReferencingResponse)_serviceProxy.Execute(canBereferencingRequest);

     if (!canBeReferencingResponse.CanBeReferencing)
     {
         Console.WriteLine(
             "Entity {0} can't be the referencing entity in this one-to-many relationship", 
             referencingEntity);
     }


     if (canBeReferencedResponse.CanBeReferenced == true
         && canBeReferencingResponse.CanBeReferencing == true)
     {
         return true;
     }
     else
     {
         return false;
     }
 }

// </snippetworkwithrelationships4>