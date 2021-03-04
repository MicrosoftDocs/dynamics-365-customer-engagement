---
title: "Create and manage custom business apps using code for Dynamics 365 Customer Engagement (on-premises) | MicrosoftDocs"
description: "Learn about how to create, manage, and publish business apps in Customer Engagement using code. Dynamics 365 Customer Engagement business apps are purpose built that provide a limited set of functionality that is relevant for a particular area of work."
ms.custom: 
ms.date: 03/04/2019
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: d1980bd7-ea0d-4a66-84c4-de602bdd867d
author: KumarVivek
ms.author: kvivek
search.audienceType: 
  - developer

---
# Create and manage custom business apps in Customer Engagement using code

Business apps in Dynamics 365 Customer Engagement are modular, purpose built apps that provide role-based functionality relevant for a particular area of work. These apps make it easier for users to quickly find things they need to do every day by providing a simple and intuitive interface. For example, the **Sales** business app provides a simpler, smaller sitemap with only the appropriate set of forms, views, dashboards, and process flows that are relevant for sales people.

System administrators and customizers can provide users access to these business apps using security roles; users can access only those apps that they have permission to. 

> [!NOTE]
> Custom business apps in Dynamics 365 Customer Engagement are the same as model-driven apps in Power Apps; both are built on the same underlying platform. More information: [What are model-driven apps?](/powerapps/maker/model-driven-apps/model-driven-app-overview)

In addition to creating custom business apps using the app designer, you can programmatically create and manage custom business apps in Dynamics 365 Customer Engagement (on-premises). 

> [!IMPORTANT]
> However, you don't have to write code to build custom business apps if you don't need to! The app designer provides a much simpler and intuitive experience for building custom business apps without having to write code by providing a tile-based information structure and simplified interface. Check it out here: [Design custom business apps by using the app designer](../customize/design-custom-business-apps-using-app-designer.md)
  
Creating a custom business app involves the following steps:
1. Create an [AppModule Entity](entities/appmodule.md) instance to define your app and its properties.
2. Add or remove components to your app such as entity, sitemap, and other components for your custom app using the <xref:Microsoft.Dynamics.CRM.AddAppComponents> and <xref:Microsoft.Dynamics.CRM.RemoveAppComponents> actions.
3. Check your app for any required components thats missing by using the <xref:Microsoft.Dynamics.CRM.ValidateApp> function.
4. Publish your app.
5. Associate appropriate security roles to your custom business app to provide access to users.


## Create your business app and define its properties

You must have the System Administrator or System Customizer security role or equivalent permissions to be able to create an app.

You must specify the following properties at a minimum to create an app:
- **name**: Unique for your app
- **uniquename**: This can be different than the name of your app, and can only have English characters and numbers. On creating this app, the name is automatically prefixed with your solution publisher prefix (for example 'new_'). 
- **webresourceid**: ID of the web resource that you want to be set as the image icon for your app. The system provides you with a default web resource (ID: 953b9fac-1e5e-e611-80d6-00155ded156f) that you can use as an icon for your app.

The following Web API request creates an Unified Interface type of an app:

```http
POST [Organization URI]/api/data/v9.1/appmodules HTTP/1.1
Content-Type: application/json; charset=utf-8
OData-MaxVersion: 4.0
OData-Version: 4.0
Accept: application/json

{
    "name": "SDKTestApp",
    "uniquename":"SDKTestApp",
    "webresourceid":"953b9fac-1e5e-e611-80d6-00155ded156f"    
}
```

The response **OData-EntityId** header contains the Uri of the created app.

```http
HTTP/1.1 204 No Content
OData-Version: 4.0
OData-EntityId: [Organization URI]/api/data/v9.1/appmodules(dd621d4a-d898-e711-80e7-00155db763be)
```  

## Add or remove components from your business app

You can add or remove components in an app such as sitemap, entity, dashboard, business process flows, views, and forms that you want to be included in your business app. For detailed information about components that can be added to a business app, see [Add or edit app components in the app designer](../customize/add-edit-app-components.md).

Use the <xref:Microsoft.Dynamics.CRM.AddAppComponents> action or the <xref:Microsoft.Crm.Sdk.Messages.AddAppComponentsRequest> message to add components to your business app. The action requires you to specify the following:
- **AppId**: ID of the app where you want to add components
- **Components** A collection of components to be added. You need to specify the ID and the entity type of the component you want to add. For a list of entity types in Customer Engagement Web API, see <xref:Microsoft.Dynamics.CRM.EntityTypeIndex>.

The following Web API request adds a view (savedquery) and a form (systemform) to your app:

```http
POST [Organization URI]/api/data/v9.1/AddAppComponents HTTP/1.1
Content-Type: application/json; charset=utf-8
OData-MaxVersion: 4.0
OData-Version: 4.0
Accept: application/json

{
	"AppId":"dd621d4a-d898-e711-80e7-00155db763be",
	"Components":[
		{
			"savedqueryid":"00000000-0000-0000-00aa-000000666000",
			"@odata.type":"Microsoft.Dynamics.CRM.savedquery"
		},
		{
			"formid":"c9e7ec2d-efca-4e4c-b3e3-f63c4bba5e4b",
			"@odata.type":"Microsoft.Dynamics.CRM.systemform"
		}
	]
}
```

To remove a component from an app, use the <xref:Microsoft.Dynamics.CRM.RemoveAppComponents> action or the <xref:Microsoft.Crm.Sdk.Messages.RemoveAppComponentsRequest> message. This action takes the same set of parameters as the **AddAppComponents** action.

The following Web API request removes a view (savedquery) from your app: 

```http
POST [Organization URI]/api/data/v9.1/RemoveAppComponents HTTP/1.1
Content-Type: application/json; charset=utf-8
OData-MaxVersion: 4.0
OData-Version: 4.0
Accept: application/json

{
	"AppId":"dd621d4a-d898-e711-80e7-00155db763be",
	"Components":[
		{
			"savedqueryid":"00000000-0000-0000-00aa-000000666000",
			"@odata.type":"Microsoft.Dynamics.CRM.savedquery"
		}
	]
}
```

## Validate your business app

Validating an app involves checking for any dependencies for the components you have added in your business app to ensure that your app works fine. This is the same as clicking **Validate** in the app designer. More information: [Validate your app](../customize/validate-app.md)

Use the <xref:Microsoft.Dynamics.CRM.ValidateApp> function or the <xref:Microsoft.Crm.Sdk.Messages.ValidateAppRequest> message to validate your app. The following Web API request shows how to validate your business app with ID: dd621d4a-d898-e711-80e7-00155db763be:

`GET [Organization URI]/api/data/v9.1/ValidateApp(AppModuleId=dd621d4a-d898-e711-80e7-00155db763be)`

If there are no validation errors, the response is as follows:

```http
HTTP/1.1 200 OK
OData-Version: 4.0

{
    "@odata.context": "[Organization URI]/api/data/v9.1/$metadata#Microsoft.Dynamics.CRM.ValidateAppResponse",
    "AppValidationResponse": {
        "ValidationSuccess": true,
        "ValidationIssueList": []
    }
}
```

If there are validation issues in your app, the response displays errors/warnings in the **ValidationIssueList** collection:

```http
HTTP/1.1 200 OK
OData-Version: 4.0

{
    "@odata.context": "[Organization URI]/api/data/v9.1/$metadata#Microsoft.Dynamics.CRM.ValidateAppResponse",
    "AppValidationResponse": {
        "ValidationSuccess": false,
        "ValidationIssueList": [
            {
                "ErrorType": "Error",
                "Message": "App does not contain Site Map",
                "DisplayName": null,
                "ComponentId": "00000000-0000-0000-0000-000000000000",
                "ComponentType": 0,
                "ComponentSubType": 0,
                "ParentEntityId": "00000000-0000-0000-0000-000000000000",
                "ParentEntityName": null,
                "CRMErrorCode": -2147155684,
                "RequiredComponents": []
            },
            {
                "ErrorType": "Warning",
                "Message": "Account doesn’t reference a form or view. App users will see all forms and views.",
                "DisplayName": null,
                "ComponentId": "00000000-0000-0000-0000-000000000000",
                "ComponentType": 0,
                "ComponentSubType": 0,
                "ParentEntityId": "00000000-0000-0000-0000-000000000000",
                "ParentEntityName": null,
                "CRMErrorCode": -2147155691,
                "RequiredComponents": []
            }
        ]
    }
}
```

## Publish your business app

After you have added required components to your custom business app and validated it, you must publish it to make it available to users.

Use the <xref:Microsoft.Dynamics.CRM.PublishXml> action or the <xref:Microsoft.Crm.Sdk.Messages.PublishXmlRequest> messageto publish your custom business app. The following request shows how to publish your business app with ID: dd621d4a-d898-e711-80e7-00155db763be:

```http
POST [Organization URI]/api/data/v9.1/PublishXml HTTP/1.1
Content-Type: application/json; charset=utf-8
OData-MaxVersion: 4.0
OData-Version: 4.0
Accept: application/json

{  
  "ParameterXml":"<importexportxml><appmodules><appmodule>dd621d4a-d898-e711-80e7-00155db763be</appmodule></appmodules></importexportxml>"
}
```

## Manage access to business app using security roles

To provide users access to your apps so that they can access it from their **Settings** > **My Apps** area or the Dynamics 365 Customer Engagement (on-premises) home page, you can associate security roles to your business apps. Users assigned to the associated security roles and can see and use your business apps in Customer Engagement. 

Use the **appmoduleroles_association** navigation property of the [AppModule Entity](entities/appmodule.md) entity to associate a business app with a security role. The following request shows how to associate a business app with a security role:

```http
POST [Organization URI]/api/data/v9.1/appmodules(dd621d4a-d898-e711-80e7-00155db763be)appmoduleroles_association/$ref HTTP/1.1
Content-Type: application/json; charset=utf-8
OData-MaxVersion: 4.0
OData-Version: 4.0
Accept: application/json

{  
  "@odata.id":"[Organization URI]/api/data/v9.1/roles(<roleId>)"
}
```

To disassociate a security role from a business app, you use the DELETE request with the same navigation property. For example:

`DELETE	[Organization URI]/api/data/v9.1/appmodules(dd621d4a-d898-e711-80e7-00155db763be)/appmoduleroles_association/$ref?$id=[Organization URI]/api/data/v9.1/roles(<roleId)
`

## Manage your business apps and its components

This section provides you information about retrieving your apps, updating app properties, retrieving app components, and deleting apps.

### Retrieve published apps
To retrieve published apps, use the following request:

`GET [Organization URI]/api/data/v9.1/appmodules?$select=name`

### Retrieve unpublished apps
To retrieve unpublished apps, use the <xref:Microsoft.Dynamics.CRM.RetrieveUnpublishedMultiple> function. For example:

`GET [Organization URI]/api/data/v9.1/appmodules/Microsoft.Dynamics.CRM.RetrieveUnpublishedMultiple()?$select=name`

### Retrieve components in a published business app
To retrieve app components for a business app, use the <xref:Microsoft.Dynamics.CRM.RetrieveAppComponents> function or the <xref:Microsoft.Crm.Sdk.Messages.RetrieveAppComponentsRequest> message. For example:

`GET [Organization URI]/api/data/v9.1/RetrieveAppComponents(AppModuleId=dd621d4a-d898-e711-80e7-00155db763be)`

### Retrieve security roles associated with published business app

To retrieve the security roles associated with your business app, use the `$expand` system query option with the **appmoduleroles_association** navigation property. For example, here is the request to retrieve all the security roles associated to a business app with ID: dd621d4a-d898-e711-80e7-00155db763be:

`GET [Organization URI]/api/data/v9.1/appmodules(dd621d4a-d898-e711-80e7-00155db763be)?$expand=appmoduleroles_association&$select=name,appmoduleroles_association`

### Delete business apps

Use the DELETE request to delete a business app. For example:

`DELETE [Organization URI]/api/data/v9.1/appmodules(dd621d4a-d898-e711-80e7-00155db763be)`

## Client API support for business apps

You can use the following client APIs to work with business apps:

- [getCurrentAppName](clientapi/reference/xrm-utility/getglobalcontext/getcurrentappname.md)
- [getCurrentAppProperties](clientapi/reference/xrm-utility/getglobalcontext/getCurrentAppProperties.md)
- [getCurrentAppUrl](clientapi/reference/xrm-utility/getglobalcontext/getCurrentAppUrl.md) 
  
### See also  
[Design custom business apps by using the app designer](../customize/design-custom-business-apps-using-app-designer.md)
 


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]