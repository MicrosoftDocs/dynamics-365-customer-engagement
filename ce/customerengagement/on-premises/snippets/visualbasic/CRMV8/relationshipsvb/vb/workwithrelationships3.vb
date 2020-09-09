' <snippetworkwithrelationships3>


 ''' <summary>
 ''' Determines whether the entity can participate in a many-to-many relationship.
 ''' </summary>
 ''' <param name="entity">Entity</param>
 ''' <returns></returns>
 Public Function EligibleCreateManyToManyRelationship(ByVal entity As String) As Boolean
  Dim canManyToManyRequest As CanManyToManyRequest =
   New CanManyToManyRequest With {.EntityName = entity}

  Dim canManyToManyResponse As CanManyToManyResponse =
   CType(_serviceProxy.Execute(canManyToManyRequest), CanManyToManyResponse)

  If Not canManyToManyResponse.CanManyToMany Then
   Console.WriteLine("Entity {0} can't participate in a many-to-many relationship.", entity)
  End If

  Return canManyToManyResponse.CanManyToMany
 End Function

' </snippetworkwithrelationships3>