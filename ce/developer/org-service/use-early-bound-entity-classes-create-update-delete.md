---
title: "Use the early-bound entity classes for create, update, and delete (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Read how to create, update and delete an entity record using the early-bound entity classes and OrganizationServiceContext class"
ms.custom: ""
ms.date: 05/09/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: aa467b48-73b0-465b-a434-1fcbc49b76b6
caps.latest.revision: 37
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Use the early-bound entity classes for create, update, and delete

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

In [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement, you can use the entity data model and the early-bound entity classes, created by the code generation tool ([!INCLUDE[sdk_CodeGenUtility](../../includes/sdk-codegenutility.md)]), to work with business data. You can use these early-bound classes with or without the organization service context, but a best practice is to use the generated organization service context class. The context attempts to manage relationships efficiently, but handwritten code can typically be even more efficient.  
  
> [!NOTE]
>  Updates to records are made in a specific order. First, primary entities are processed, and then related entities are processed. If a change is made by the primary entity for a lookup or related entity attribute, and then a related entity updates the same attribute, the related entity value is retained. In general, a lookup attribute value and its equivalent in the `RelatedEntities` (or navigation properties) for the same relationship should not be used at the same time.  
  
<a name="use_context"></a>   

## Use the OrganizationServiceContext class  

 The organization service context class that the code generation tool creates and that inherits from <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceContext> is used to track data changes. The context tracks objects that are instances of entity types that represent data in [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)]. You can modify, create, and delete objects in the organization service context, and [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] tracks the changes that you made to these objects. When the <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceContext>.<xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceContext.SaveChanges> method is called, [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] generates and executes commands that perform the equivalent insert, update, or delete statements against data in [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)].  
  
 When working with early-bound entity classes, you use the entity name and attribute schema name to specify an entity or attribute to work with. Attribute schema names are defined in <xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata>.<xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata.SchemaName> and <xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata>.<xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata.SchemaName>, or you can use the class and property names shown in the code-generated file.The following sample shows how to assign a value to the email attribute of a new contact instance.  
  
```csharp  
Contact contact = new Contact();
contact.EMailAddress1 = “sonny@contoso.com”;  
```  
  
 For a complete code sample that shows how to use early-bound entity classes to perform basic database actions, see [Sample: Create, Retrieve, Update and Delete (CRUD) Using Strong Types](sample-create-retrieve-update-delete-records-early-bound.md).  
  
<a name="create_new"></a>   

## Create a new entity record using the early-bound entity classes and the OrganizationServiceContext class  

 When you want to insert data into [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] by using the entity data model, you must create an instance of an entity type and add the object to an organization service context. The organization service context must be tracking the object before it can save the object to [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)].  
  
 When creating a new entity record, you add the object to the organization service context by using the <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceContext.AddObject(Microsoft.Xrm.Sdk.Entity)>. method.  
  
 The following sample shows how to instantiate and save a new contact record by using the entity data model. It also demonstrates how tp access a custom attribute.  
  
```csharp  
OrganizationServiceContext orgContext =new OrganizationServiceContext(_serviceProxy);  
Contact contact = new Contact()     
 {  
   FirstName = "Charles",  
   LastName = "Brown",  
   Address1_Line1 = "123 Main St.",  
   Address1_City = "Des Moines",  
   Address1_StateOrProvince = "IA",  
   Address1_PostalCode = "21254",  
   new_twittername = "Chuck",  
   Telephone1 = "123-234-5678"  
 };   
orgContext.AddObject(contact);orgContext.SaveChanges();  
```  
  
 After you add an object to the context and before the <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceContext>.<xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceContext.SaveChanges> method is called, the context generates an ID for the new object. An exception that contains the `SaveChangesResults` is thrown from the <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceContext.SaveChanges> method if any updates to the [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] data fail.  
  
<a name="update"></a>   

## Update an entity record using early-bound entity classes and the OrganizationServiceContext class  

 [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] tracks changes to objects that are attached to the organization service context. To modify an existing entity record, you must first add the object to the context. To add an object to the context, you must first retrieve the entity record from [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] and then add the object to the context by using the <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceContext.Attach(Microsoft.Xrm.Sdk.Entity)> method. Once the object is being tracked by the context, you can update the record by setting the entity’s attributes.  
  
 The following sample shows how to update an account attribute by using early bound classes.  
  
```csharp  
Account.EMailAddress1 = “Contoso-WebMaster@contoso.com”;  
```  
  
 The following sample shows how to delete an attribute value.  
  
```csharp  
Account.EMailAddress1 = null;  
```  
  
 There are two partial methods named `OnPropertyChanging` and `OnPropertyChanged` for each entity. These methods are called in the property setter. You can extend these methods by using partial classes to insert custom business logic.  
  
<a name="delete"></a>   

## Delete an entity record using early-bound entity classes and the OrganizationServiceContext class  

 To delete an entity record, the organization service context must be tracking the object. Once the object is on the context, you can use the <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceContext.DeleteObject(Microsoft.Xrm.Sdk.Entity)> method to mark the object on the context for deletion. Note that the entity record in [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] is not deleted until the <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceContext>.<xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceContext.SaveChanges> method is called.  
  
<a name="no_context"></a>   

## Use early-bound entity classes without a Context object  

 You can use the early-bound entity classes without creating an organization service context object if you do not want to create the context object. The <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceProxy> class includes a <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceProxy.Create(Microsoft.Xrm.Sdk.Entity)> method that can be used to save entity record changes to [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)].  
  
 The following sample shows how to use an early-bound entity class without creating an organization service context object. The  <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceProxy.Create(Microsoft.Xrm.Sdk.Entity)> method returns the `GUID` id assigned to the newly created entity record.  
  
```csharp  
Contact contact = new Contact()  
 {  
   FirstName = "Charles",  
   LastName = "Brown",  
   Address1_Line1 = "123 Main St.",  
   Address1_City = "Des Moines",  
   Address1_StateOrProvince = "IA",  
   Address1_PostalCode = "21254",  
   Telephone1 = "123-234-5678"   
  };  
 _contactId = _serviceProxy.Create(contact);   
```  
  
 To update an entity record in [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)], you retrieve the data to be updated, make the necessary changes, and then use the <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceProxy>.<xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceProxy.Update(Microsoft.Xrm.Sdk.Entity)> method to commit those changes to [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)]. 

> [!IMPORTANT]
>  When updating an entity, only include the attributes you are changing. Simply updating the attributes of an entity that you previously retrieved will update each attribute even though the value is unchanged. This can cause system events that can trigger business logic that expects that the values have actually changed. This can also cause attributes to appear to have been updated in auditing data when in fact they haven’t actually changed. 
>
> You should create a new entity instance, set the id attribute and any attribute values you are changing, and use that entity instance to update the record.


To retrieve entity records, you use the <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceProxy>.<xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceProxy.Retrieve(System.String,System.Guid,Microsoft.Xrm.Sdk.Query.ColumnSet)> method for single-object retrieval or the <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceProxy>. <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceProxy.RetrieveMultiple(Microsoft.Xrm.Sdk.Query.QueryBase)> method for retrieving multiple objects. To delete an entity record, you use the <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceProxy>.<xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceProxy.Delete(System.String,System.Guid)> method.  
  
### See also  

 [Use the Early Bound Entity Classes in Code](use-early-bound-entity-classes-code.md)   
 [Use the early bound entity classes to associate records](use-early-bound-entity-classes-associate-records.md)   
 [Create Strong Types with the Code Generation Tool (CrmSvcUtil.exe)](create-early-bound-entity-classes-code-generation-tool.md)   
 [Sample: Create, Retrieve, Update and Delete (CRUD) Using Strong Types](sample-create-retrieve-update-delete-records-early-bound.md)
