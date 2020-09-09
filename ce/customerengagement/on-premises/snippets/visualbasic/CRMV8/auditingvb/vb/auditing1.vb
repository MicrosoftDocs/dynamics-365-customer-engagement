' <snippetauditing1>


 Console.WriteLine("Enabling auditing on the organization and account entities.")

 ' Enable auditing on the organization.
 ' First, get the organization's ID from the system user record.
 Dim orgId As Guid = (CType(_service.Execute(New WhoAmIRequest()), WhoAmIResponse)).OrganizationId

 ' Next, retrieve the organization's record.
 Dim org As Organization = TryCast(_service.Retrieve(Organization.EntityLogicalName, orgId, New ColumnSet(New String() {"organizationid", "isauditenabled"})), Organization)

 ' Finally, enable auditing on the organization.
 Dim organizationAuditingFlag As Boolean = org.IsAuditEnabled.Value
 org.IsAuditEnabled = True
 _service.Update(org)

 ' Enable auditing on account entities.
 Dim accountAuditingFlag As Boolean = EnableEntityAuditing(Account.EntityLogicalName, True)

' </snippetauditing1>