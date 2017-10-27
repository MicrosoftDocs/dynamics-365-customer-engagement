---
title: "Retrieve records for many-to-many relationships using intersect entities (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "An intersect entity is automatically created when there is a many-to-many (N:N) relationship between two entities. Read how you can retrieve records for many-to-many relationships using intersect entities. This topic lists the intersect entities that are used in N:N relationships between default entities"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: b7987bf2-3915-4ddb-b76f-1cc4a1e44404
caps.latest.revision: 37
author: "KumarVivek"
ms.author: "kvivek"
manager: "jdaly"
---

# Retrieve records for many-to-many relationships using intersect entities
In [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement, when there is a many-to-many (N:N) relationship between two entities, an intersect entity is automatically created. This is true for both system relationships built into the product as well as custom many-to-many relationships. The name of the entity is specified in the <xref:Microsoft.Xrm.Sdk.Metadata.ManyToManyRelationshipMetadata.IntersectEntityName> property in the relationship metadata. The name of the relationship is specified in the <xref:Microsoft.Xrm.Sdk.Relationship.SchemaName> property in the relationship metadata.  
  
 You can use the intersect entities to refine the result set in any query by using the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*> method or the <xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> message. However, you cannot retrieve the intersect entity records directly by using the <xref:Microsoft.Xrm.Sdk.Query.QueryExpression> class. To retrieve the records in an intersect entity, you must use the <xref:Microsoft.Xrm.Sdk.Query.FetchExpression> class.  
  
<a name="BKMK_Entities"></a>   
## Intersect entities  
 The following table lists the intersect entities that are used in N:N relationships between default entities.  
  
|IntersectEntity|MtoM_SchemaName|MtoM_Entity1|MtoM_Entity2|  
|---------------------|----------------------|-------------------|-------------------|  
|accountleads|accountleads_association|account|lead|  
|campaignactivityitem|campaignactivitylist_association|campaignactivity|list|  
|campaignactivityitem|campaignactivitysalesliterature_association|campaignactivity|salesliterature|  
|campaignitem|campaigncampaign_association|campaign|campaign|  
|campaignitem|campaignlist_association|campaign|list|  
|campaignitem|campaignproduct_association|campaign|product|  
|campaignitem|campaignsalesliterature_association|campaign|salesliterature|  
|competitorproduct|competitorproduct_association|competitor|product|  
|competitorsalesliterature|competitorsalesliterature_association|salesliterature|competitor|  
|connectionroleassociation|connectionroleassociation_association|connectionrole|connectionrole|  
|contactinvoices|contactinvoices_association|invoice|contact|  
|contactleads|contactleads_association|contact|lead|  
|contactorders|contactorders_association|salesorder|contact|  
|contactquotes|contactquotes_association|quote|contact|  
|entitlementcontacts|entitlementcontacts_association|contact|entitlement|  
|entitlementproducts|product_entitlement_association|product|entitlement|  
|entitlementtemplateproducts|product_entitlementtemplate_association|product|entitlementtemplate|  
|leadcompetitors|leadcompetitors_association|lead|competitor|  
|leadproduct|leadproduct_association|lead|product|  
|listmember|listaccount_association|list|account|  
|listmember|listcontact_association|list|contact|  
|listmember|listlead_association|list|lead|  
|opportunitycompetitors|opportunitycompetitors_association|opportunity|competitor|  
|productassociation|productassociation_association|product|product|  
|productsalesliterature|productsalesliterature_association|product|salesliterature|  
|productsubstitute|productsubstitute_association|product|product|  
|queuemembership|queuemembership_association|queue|systemuser|  
|roleprivileges|roleprivileges_association|privilege|role|  
|roletemplateprivileges|roletemplateprivileges_association|roletemplate|privilege|  
|servicecontractcontacts|servicecontractcontacts_association|contact|contract|  
|subscriptionmanuallytrackedobject|contact_subscription_association|subscription|contact|  
|subscriptionmanuallytrackedobject|task_subscription_association|subscription|task|  
|systemuserprofiles|systemuserprofiles_association|systemuser|fieldsecurityprofile|  
|systemuserroles|systemuserroles_association|systemuser|role|  
|teammembership|teammembership_association|team|systemuser|  
|teamprofiles|teamprofiles_association|team|fieldsecurityprofile|  
|teamroles|teamroles_association|team|role|  
  
<a name="BKMK_metadata"></a>   
## Intersect entity metadata  
 Most intersect entities are simple, containing just the few properties that are needed to provide a link between to two entities in the N:N relationship. If you are using early bound types,  you can see an example, in the `ContactInvoices` intersect entity. This is the case for all custom many-to-many relationships. However, there are several intersect entities that have additional properties that are used for specific functionality for the relationship. To make it easier to write queries by using the special intersect entities, the attribute metadata is provided in the following topics:  
  
-   [Campaign Activity Item Intersect Entity](campaignactivityitem-intersect-entity-metadata.md)  
  
-   [Campaign Item Intersect Entity](campaignitem-intersect-entity-metadata.md)  
  
-   [List Member Intersect Entity](listmember-intersect-entity-metadata.md)  
  
-   [Role Privileges Intersect Entity](role-privileges-intersect-entity-metadata.md)  
  
### See also  
 [Building Queries](build-queries-with-queryexpression.md)   
 [Customize entity relationship metadata](../customize-entity-relationship-metadata.md)   
 [Retrieve data with queries](retrieve-data-queries-sdk-assemblies.md)   
 [CampaignActivityItem intersect entity metadata](campaignactivityitem-intersect-entity-metadata.md)   
 [CampaignItem intersect entity metadata](campaignitem-intersect-entity-metadata.md)   
 [ListMember intersect entity metadata](listmember-intersect-entity-metadata.md)   
 [Role Privileges intersect entity metadata](role-privileges-intersect-entity-metadata.md)   
 [Sample: Retrieve Records from an Intersect Table](sample-retrieve-records-intersect-table.md)
