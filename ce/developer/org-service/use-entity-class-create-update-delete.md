---
title: "Use the Entity class for create, update and delete (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Read how you can use the Entity class to create, update, and delete entities and entity attributes"
ms.custom: ""
ms.date: 05/09/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: d0eb57ae-7f45-4bde-964e-da2c6bd1f405
caps.latest.revision: 22
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Use the Entity class for create, update and delete

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

In [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement, you can use the <xref:Microsoft.Xrm.Sdk.Entity> class to create, update, and delete entities and entity attributes.  
  
## Create, update, and delete using the Entity class  
 When you work with the <xref:Microsoft.Xrm.Sdk.Entity> class and use late binding, you work with the entity and logical attribute name. This contrasts with early binding where you work with the entity and attribute schema name. The logical attribute name is all lowercase whereas the schema attribute name uses Pascal casing.  
  
 To create a new entity, you first create a new instance of the <xref:Microsoft.Xrm.Sdk.Entity> class and pass it an entity name. The following code example shows how to create a new account record.  
  
```csharp  
// Instantiate an account object.  
Entity account = new Entity("account");  
  
// Set the required attributes. For account, only the name is required.   
// See the metadata to determine   
// which attributes must be set for each entity.  
account["name"] = "Fourth Coffee";  
  
// Create an account record named Fourth Coffee.  
_accountId = _orgService.Create(account);  
```  
  
 In the example, a new entity object is created of type “account,” attributes are set, and then the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*> method is called to create the new record.  
  
 To update an entity, you set a value for the attribute to be updated, and then call the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*> method. 

> [!IMPORTANT]
>  When updating an entity, only include the attributes you are changing. Simply updating the attributes of an entity that you previously retrieved will update each attribute even though the value is unchanged. This can cause system events that can trigger business logic that expects that the values have actually changed. This can also cause attributes to appear to have been updated in auditing data when in fact they haven’t actually changed.
>
> You should create a new entity instance, set the id attribute and any attribute values you are changing, and use that entity instance to update the record.


The following code example shows how to update an attribute in an account.  
  
```csharp  
string newPostalCode = "98052";
Entity account = new Entity("account");  
// Create a column set to define which attributes should be retrieved.  
ColumnSet attributes = new ColumnSet(new string[] { "name", "ownerid", "address1_postalcode" });   

// Retrieve the account and its name, ownerid, and address1_postalcode attributes.  
account = _orgService.Retrieve(account.LogicalName, _accountId, attributes);  

// Test to make sure that the existing value isn’t the same as the current value  
if(account["address1_postalcode"] != newPostalCode)
{
// Create a new entity instance for update
Entity accountToUpdate = new Entity("account");  

// Set the unique identifier for the account to update.
accountToUpdate["accountid"] = account["accountid"];
// Update the postal code attribute.  
accountToUpdate["address1_postalcode"] = newPostalCode;  

// Update the account.  
_orgService.Update(accountToUpdate); 
}
```  
  
 To delete an entity, you can pass the key attribute information to the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*> method. The following code example shows how to use the `Delete` method.  
  
```csharp 
_orgService.Delete("account", _accountId);  
```  
  
### See also  
 [Use the Entity Class to Add or Update Associations Between Related Records](use-entity-class-add-update-associations-records.md)   
 [Use the Late Bound Entity Class](use-late-bound-entity-class-code.md)
