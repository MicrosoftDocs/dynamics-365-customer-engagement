// <snippetworkwithrelationships3>


 /// <summary>
 /// Determines whether the entity can participate in a many-to-many relationship.
 /// </summary>
 /// <param name="entity">Entity</param>
 /// <returns></returns>
 public bool EligibleCreateManyToManyRelationship(string entity)
 {
     CanManyToManyRequest canManyToManyRequest = new CanManyToManyRequest
     {
         EntityName = entity
     };

     CanManyToManyResponse canManyToManyResponse =
         (CanManyToManyResponse)_serviceProxy.Execute(canManyToManyRequest);

     if (!canManyToManyResponse.CanManyToMany)
     {
         Console.WriteLine(
             "Entity {0} can't participate in a many-to-many relationship.", 
             entity);
     }

     return canManyToManyResponse.CanManyToMany;
 }

// </snippetworkwithrelationships3>