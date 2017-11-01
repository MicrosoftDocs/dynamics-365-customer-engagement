// <snippetcrmconnect>


	Guid orgId = ((WhoAmIResponse)_orgServiceProxy.Execute(new WhoAmIRequest())).OrganizationId;

	//Obtaining user's systemuserid
	RetrieveUserIdByExternalIdRequest request = new RetrieveUserIdByExternalIdRequest();
	request.ExternalId = "C:" + upn;
	request.OrganizationId = orgId;

	RetrieveUserIdByExternalIdResponse response = (RetrieveUserIdByExternalIdResponse)_discServiceProxy.Execute(request);
	Guid userId = response.UserId;

// </snippetcrmconnect>