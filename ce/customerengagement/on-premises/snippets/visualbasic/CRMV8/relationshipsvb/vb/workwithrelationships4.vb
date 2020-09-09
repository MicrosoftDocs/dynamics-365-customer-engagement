' <snippetworkwithrelationships4>


 ''' <summary>
 ''' Determines whether two entities are eligible to participate in a relationship
 ''' </summary>
 ''' <param name="referencedEntity">Primary Entity</param>
 ''' <param name="referencingEntity">Referencing Entity</param>
 ''' <returns></returns>
 Public Function EligibleCreateOneToManyRelationship(ByVal referencedEntity As String, ByVal referencingEntity As String) As Boolean
  'Checks whether the specified entity can be the primary entity in one-to-many
  'relationship.
  Dim canBeReferencedRequest As CanBeReferencedRequest =
   New CanBeReferencedRequest With {.EntityName = referencedEntity}

  Dim canBeReferencedResponse As CanBeReferencedResponse =
   CType(_serviceProxy.Execute(canBeReferencedRequest), CanBeReferencedResponse)

  If Not canBeReferencedResponse.CanBeReferenced Then
   Console.WriteLine("Entity {0} can't be the primary entity in this one-to-many relationship", referencedEntity)
  End If

  'Checks whether the specified entity can be the referencing entity in one-to-many
  'relationship.
  Dim canBereferencingRequest As CanBeReferencingRequest =
   New CanBeReferencingRequest With {.EntityName = referencingEntity}

  Dim canBeReferencingResponse As CanBeReferencingResponse =
   CType(_serviceProxy.Execute(canBereferencingRequest), CanBeReferencingResponse)

  If Not canBeReferencingResponse.CanBeReferencing Then
   Console.WriteLine("Entity {0} can't be the referencing entity in this one-to-many relationship", referencingEntity)
  End If


  If canBeReferencedResponse.CanBeReferenced = True AndAlso canBeReferencingResponse.CanBeReferencing = True Then
   Return True
  Else
   Return False
  End If
 End Function

' </snippetworkwithrelationships4>