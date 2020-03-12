// <snippetauditing1>


 Console.WriteLine("Enabling auditing on the organization and account entities.");

 // Enable auditing on the organization.
 // First, get the organization's ID from the system user record.
 Guid orgId = ((WhoAmIResponse)_service.Execute(new WhoAmIRequest())).OrganizationId;

 // Next, retrieve the organization's record.
 Organization org = _service.Retrieve(Organization.EntityLogicalName, orgId,
     new ColumnSet(new string[] { "organizationid", "isauditenabled" })) as Organization;

 // Finally, enable auditing on the organization.
 bool organizationAuditingFlag = org.IsAuditEnabled.Value;
 org.IsAuditEnabled = true;
 _service.Update(org);

 // Enable auditing on account entities.
 bool accountAuditingFlag = EnableEntityAuditing(Account.EntityLogicalName, true);

// </snippetauditing1>