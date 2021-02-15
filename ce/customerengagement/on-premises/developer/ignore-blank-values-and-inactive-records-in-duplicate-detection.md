---
title: "Ignore blank values and inactive records in duplicate detection (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Improve result quality by creating duplicate detection rules that ignore blank values and inactive records."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 7b905429-1bde-4ba5-a523-62ab770b2582
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Ignore blank values and inactive records in duplicate detection

You can improve data results by creating duplicate detection rules that ignore blank values and inactive records. This will help to refine your results and reduce the amount of erroneous data.  
  
## Rules for Ignoring Blank Values and Inactive Records  
 A duplicate detection rule can have more than one rule condition. For example, you can specify that an account is a duplicate of another record if both of the following conditions are satisfied:  
  
- Account names match in both records.  
  
- Email IDs match in both records.  
  
  However, with this rule, the system flags any two records as duplicates if the account names match and the email IDs are null values. In another example, two records are flagged as duplicates if their email IDs and status match. In this case, all active, and inactive, records that have email IDs equal to **null** are flagged as duplicates. This may flood a system with a large number of unintended duplicate records. To avoid flagging inactive records and records with null values as duplicates, two new attributes were added, `IgnoreBlankValues`and `ExcludeInactiveRecords`.  
  
  The following table describes the new attributes.  
  
|          Entity          |        Attribute         |  Type   |                                                                                                                                                                                                                                                                    Description                                                                                                                                                                                                                                                                     |
|--------------------------|--------------------------|---------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| `DuplicateRuleCondition` |   `IgnoreBlankValues`    | Boolean | Specifies whether to consider blank values as non-duplicate values. The default value of this attribute is `false`. Set it to `true`if you do not want the duplicate detection rule to consider **null**) values as equal. When you upgrade from earlier versions of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], this attribute is set to `false`.<br /><br /> Important:<br /><br /> For a duplicate detection rule with one condition, if you set the attribute value to `false`, it is treated by the system as a `true`value. |
|     `DuplicateRule`      | `ExcludeInactiveRecords` | Boolean |                                                                       Specifies whether to flag inactive records as duplicates. The default value is `false`. Set it to                              `true`if you do not want inactive records to be flagged as duplicates, even if they meet duplication detection rule criteria. When you upgrade from earlier versions of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], this attribute is set to `false`.                                                                        |
  
 There are entities that have states other than Active and Inactive. If you set the `ExcludeInactiveRecords`attribute to `true`, the duplicate detection process will consider matching records only in the Active states or in states that are considered Active.  
  
 The following table lists the entity records and the corresponding states.  
  
|Entity Record|Considered as Active State|Considered as Inactive State|  
|-------------------|--------------------------------|----------------------------------|  
|`Appointment`|Open, Scheduled|Completed, Canceled|  
|`CampaignActivity`|Open|Closed, Canceled|  
|`CampaignResponse`|Open|Completed, Canceled|  
|`Contract`|Draft, Invoiced, On Hold|Canceled, Expired|  
|`ContractDetail`|Existing, Renewed|Canceled, Expired|  
|`Email`|Open|Completed, Canceled|  
|`Fax`|Open|Completed, Canceled|  
|`Incident`|Active|Resolved, Canceled, Closed|  
|`Invoice`|Active|Closed, Paid, Canceled|  
|`KbArticle`|Draft, Unapproved, Published|N/A|  
|`Lead`|Open|Qualified, Disqualified|  
|`Letter`|Open|Completed, Canceled|  
|`Opportunity`|Open|Won, Lost|  
|`PhoneCall`|Open|Completed, Canceled|  
|`Quote`|Draft, Active|Won, Closed|  
|`SalesOrder`|Active, Submitted, Invoiced|Canceled, Fulfilled|  
|`ServiceAppointment`|Open, Scheduled|Closed, Canceled|  
|`Task`|Open|Completed, Canceled|  
  
 For example, if you set the `ExcludeInactiveRecords`attribute to `true`, only active, submitted, and invoiced sales orders will be considered for matching during duplicate detection.  
  
### See also  
 [Detect Duplicate Data in Dynamics 365 Customer Engagement (on-premises)](detect-duplicate-data-for-developers.md)   
 [Enable and Disable duplicate detection](enable-disable-duplicate-detection.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]