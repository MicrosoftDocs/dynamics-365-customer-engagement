---
title: "Use field security to control access to field values (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Provides field-level security to restrict access to high business impact (custom and OOB) fields to specific users and teams."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - field-level security in CRM, when aggregating on secured attributes
  - field-level security in CRM, explained
  - field-level security in CRM, when ordering on secured attributes
  - controlling access to field values by using field-level security
  - field-level security in CRM, behavior of secured fields when sharing records
  - secured fields
  - field-level security in CRM, behavior of secured fields for Create or Update
  - field-level security in CRM, when grouping on secured attributes
  - field-level security in CRM, behavior of secured fields for filtered views or offline synchronization
  - using field-level security to control access to field values in CRM
  - security roles that allow access to secured fields
  - field-level security in CRM, secured attributes in column sets
  - field-level security in CRM, secured attributes in the filter condition
ms.assetid: bd42f612-f01c-47dd-9859-69f6024af263
caps.latest.revision: 42
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---

# Use field security to control access to field values

In Dynamics 365 Customer Engagement (on-premises), you use field-level security to restrict access to high business impact fields to specific users and teams. For example, you use this to enable only certain users to read or update the credit score for a customer. For this release, field-level security can be applied to both custom fields and many out-of-box (OOB) fields.  
  
 The following steps describe how to restrict access to a field:  
  
1. Enable field-level security for an attribute  
  
2. Create a field-level security profile  
  
3. Associate users or teams with the profile  
  
4. Add specific field permissions, such as Create, Update or Read for a specific attribute to the profile  
  
   The following diagram shows the interaction between role-based security and field-level security.
  
   ![Role&#45;based compared to field&#45;level security](../media/crm-v5s-sm-fieldlevelsecurity.png "Role-based compared to field-level security")  
  
   Role-based security lets you see records of a specific entity type, record-based security lets you see individual records, and field-level security lets you see specific fields.  
  
   [Video: Field Level Security in Microsoft Dynamics CRM 2015](https://youtu.be/Czc9sKvWd9k)  
  
## Frequently asked questions  
  
-   [Which attributes can be secured?](use-field-security-control-access-field-values.md#bkmk_canbesecured)  
  
-   [Which security roles allow you to see secured fields?](use-field-security-control-access-field-values.md#BKMK_SecurityRoles)  
  
-   [How do secured fields behave for Retrieve and RetrieveMultiple?](use-field-security-control-access-field-values.md#BKMK_Retrieve)  
  
-   [How do secured fields behave for create or update?](use-field-security-control-access-field-values.md#BKMK_createAndUpdate)  
  
-   [How do secured fields behave when records are shared?](use-field-security-control-access-field-values.md#BKMK_Sharing)  
  
-   [How do secured fields behave for filtered views?](use-field-security-control-access-field-values.md#BKMK_filteredViews)  
  
-   [How do secured fields behave for offline synchronization?](use-field-security-control-access-field-values.md#BKMK_OfflineSync)  
  
<a name="bkmk_canbesecured"></a>   
## Which attributes can be secured?  
 To see which attributes can be secured, you can query the entity metadata for the following properties:  
  
- <xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata.CanBeSecuredForCreate>  
  
- <xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata.CanBeSecuredForRead>  
  
- <xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata.CanBeSecuredForUpdate>  
  
  There are thousands of attributes that can be secured, so there are two easier ways to look for this information. [!INCLUDE[metadata_browser](../../includes/metadata-browser.md)]  
  
  There are a few additional rules that apply to certain attribute data types:  
  
- Boolean attributes can be secured for create and update operations but not for read.  
  
- Option set attributes can be secured for create, update, and read when a default value is unspecified.  
  
<a name="BKMK_SecurityRoles"></a>   
## Which security roles allow you to see secured fields?  
 The System Administrator field security profile gives full access to all secured fields in Dynamics 365 Customer Engagement (on-premises).  By default, all users who have the System Administrator security role have this profile. This profile is system managed and can’t be updated or deleted.  
  
<a name="BKMK_Retrieve"></a>   
## How do secured fields behave for Retrieve and RetrieveMultiple?  
 When you call the `Retrieve` or `RetrieveMultiple` methods or messages, Dynamics 365 Customer Engagement (on-premises) evaluates if the caller and the impersonated user have access to each retrieved record (this is the regular security process) and each secured field. The call does not throw an exception if the criteria contain secured fields for which the caller does not have access. Instead, null values are returned for secured fields if they are part of the output column set.  
  
 The following describes more about the retrieve multiple behaviors for secured fields.  
  
### When a secured attribute is in the column set  
 If the caller (or impersonated user) does not have read access to the secured fields that are included in a column set, the value returns as **null**. You cannot tell the difference between a returned **null** value caused by no data or caused by insufficient access.  
  
### When a secured attribute is in the filter condition  
 If the caller (or impersonated user) does not have access to the secured fields that are included in the filter criteria, the field value is substituted with **null** during the evaluation of the filter.  
  
 In the following table, the caller has access to all attributes except those indicated with an asterisk (*).  
  
|Record Number|Value of the Name attribute|Value of the Description attribute|Value of the Can Be Contacted attribute|  
|-------------------|---------------------------------|----------------------------------------|---------------------------------------------|  
|1|A|AAA|True|  
|2|B|BBB|False|  
|3|C|CCC|**True** <sup>*</sup>|  
|4|D|DDD|Null|  
|*5* <sup>*</sup>|*E* <sup>*</sup>|*EEE* <sup>*</sup>|*Null* <sup>*</sup>|  
  
 When the filter is `CanbeContacted == True`, only record one is returned.  
  
 When the filter is `IsNULL` (CanbeContacted), records 3 and 4 are returned. Since record 3 is hidden from the user, it is treated as **null** during condition evaluation and will be evaluated as `True` for `ISNull`.  
  
### When aggregating on secured attributes  
 Secured values are substituted with a null value, so normal SQL aggregation behavior applies.  
  
### When grouping on secured attributes  
 If the caller (or impersonated user) does not have access to the attribute used for grouping, the value is treated as **null** and the results are grouped together with all **null** values.  
  
 In the following example, the caller has access to some attributes. **Bold** indicates no access to attributes, also indicated with <em>. *Italics</em> indicate a record for which the caller does not have read access, also indicated with **.  
  
|Name|Description|Number of orders|State|  
|----------|-----------------|----------------------|-----------|  
|A|AAA|1|WA|  
|B|BBB|4|WA|  
|C|CCC|4|CA|  
|*D* <sup>**</sup>|*DDD* <sup>**</sup>|*3* <sup>**</sup>|*MA* <sup>**</sup>|  
|E|EEE|0|CA|  
|F|FFF|0|**WA** <sup>*</sup>|  
|G|GGG|2|**CA** <sup>*</sup>|  
  
 `Select State, Total(orders) Group by (STATE)` results in the following:  
  
 WA–5  
  
 CA–4  
  
 **null**–2  
  
### When ordering on secured attributes  
 If the caller (or impersonated user) does not have access to secured fields that are included in an order by condition, the values will be treated as if they are **null**.  
  
 In the following example, the caller has access to attributes that are in plain text. **Bold** indicates no access to attributes, also indicated with an asterisk (<em>). *Italics</em> indicate a record for which the caller does not have read access, also indicated with **.  
  
|Name|Description|CanbeContacted|  
|----------|-----------------|--------------------|  
|A|AAA|True|  
|B|BBB|False|  
|C|**CCC** <sup>*</sup>|**True** <sup>*</sup>|  
|D|DDD|Null|  
|E|**EEE** <sup>*</sup>|**Null** <sup>*</sup>|  
|*F* <sup>**</sup>|*FFF* <sup>**</sup>|*True* <sup>**</sup>|  
|G|Null|True|  
  
 `Select Name order by Description ascending` results in the following:  
  
 {G,E,C},A, B, D, will be returned.  
  
<a name="BKMK_createAndUpdate"></a>   
## How do secured fields behave for create or update?  
 A programmer may build a client that uses `Create` and `Update` methods that interact with secured fields. When you call the `Create` or `Update` method, passing data for secured fields and the caller does not have sufficient permissions, an exception is thrown.  
  
<a name="BKMK_Sharing"></a>   
## How do secured fields behave when records are shared?  
 A user with access to a secured field in a record can share it with another user or team. The user can only give the access that they have on the record. For example, to share the record and grant Update privileges, the user must have update privileges.  
  
 You can share a secured field on a particular record with Read and/or Update with a security principal (user or team).  The user or team members with whom the record was shared now have that type of secured field access **only** on the shared secured fields on **only** that particular record, even if the user or team member to whom it was shared does not have a field security profile that gives them access.  
  
<a name="BKMK_filteredViews"></a>   
## How do secured fields behave for filtered views?  
 An administrator secures a number of fields for access in the application and wants the fields not to be available in reports. This allows for maintaining the same set of reports for all users. Filtered views will not return data for the secured fields if the calling user does not have authorization for the fields. When no field security is applied for any of the view’s attributes, the filtered views return complete data.  
  
<a name="BKMK_OfflineSync"></a>   
## How do secured fields behave for offline synchronization?  
 If you are using [!INCLUDE[pn_crm_outlook_offline_access](../../includes/pn-crm-outlook-offline-access.md)], only the secured field values that you have access to replicate into the offline database. If you don’t have access to the data, it is not saved offline.  
  
### See also  
 [Video: Field Level Security in Microsoft Dynamics CRM 2015](https://youtu.be/Czc9sKvWd9k)   
 [The Security Model of Microsoft Dynamics 365 Customer Engagement](security-model.md)   
 [How role-based security can be used to control access to entities in Microsoft Dynamics 365 Customer Engagement](how-role-based-security-control-access-entities.md)   
 [Use record-based security to control access to records](use-record-based-security-control-access-records.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]