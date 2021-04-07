---
title: "Define calculated fields with Dynamics 365 Customer Engagement (on-premises) | MicrosoftDocs"
description: "Learn how to define calculated fields"
ms.custom: 
ms.date: 11/28/2018
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - powerapps
author: Mattp123
ms.assetid: 6d58a297-2ddf-4236-be3a-47249b49d5fa
caps.latest.revision: 67
ms.author: matp
manager: kvivek
search.audienceType: 
  - customizer

---
# Define calculated fields to automate manual calculations

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Define calculated fields to automate manual calculations](/powerapps/maker/common-data-service/define-calculated-fields)

Calculated fields let you automate manual calculations used in your business processes. For example, a salesperson may want to know the weighted revenue for an opportunity which is based on the estimated revenue from an opportunity multiplied by the probability. Or, they want to automatically apply a discount, if an order is greater than $500. A calculated field can contain values resulting from simple math operations, or conditional operations, such as greater than or if-else, and many others. You can accomplish all this by using the calculated fields feature; no need to write code.  
  
 **The calculated field capabilities:**  
  
- The calculated fields comprise of calculations that use the fields from the current entity or related parent entities.  
  
- The expression support is available on the current entity and the related parent entity fields in the **Condition** sections and the **Action** sections. The built-in functions include:  
  
  **ADDHOURS**, **ADDDAYS**, **ADDWEEKS**, **ADDMONTHS**, **ADDYEARS**, **SUBTRACTHOURS**, **SUBTRACTDAYS**, **SUBTRACTWEEKS**, **SUBTRACTMONTHS**, **SUBTRACTYEARS**, **DIFFINDAYS**, **DIFFINHOURS**, **DIFFINMINUTES**, **DIFFINMONTHS**, **DIFFINWEEKS**, **DIFFINYEARS**, **CONCAT**, **TRIMLEFT**, and **TRIMRIGHT**.  
  
- A rich conditional support provides branching and multiple conditions. The logical operations include **AND** and **OR** operators.  
  
- The visual editing capabilities include modern user interface and intellisense in the **ACTION** section.  
  
- A seamless integration of the calculated fields with the forms, views, charts, and reports is available in real time.  
  
- If you updated your Online organization to [!INCLUDE[pn_crm_8_2_0_online](../includes/pn-crm-8-2-0-online.md)], you can configure calculated fields to use custom controls.  
  
  
 **A few examples of the calculated fields**  
  
-   Weighted Revenue: Estimated revenue multiplied by probability  
  
-   Net Worth: Assets subtracted by the liabilities for a given account  
  
-   Cost of Labor: Base rate up to 40 hours, plus additional overtime  
  
-   Contact Number: Phone number for an opportunity based on account or contact  
  
-   Lead Score: Single field that provides insights to the quality of a given lead  
  
-   Follow Up By: Follow up on an activity by a specified number of days based on priority  
  
> [!IMPORTANT]
>  To create a calculated field you must have the Write privilege on the Field Security Profile entity. If the calculated field uses the secured fields in a calculation, you should consider securing the calculated field as well, to prevent users from accessing data for which they don’t have sufficient permissions. The calculated field editor gives you a warning if you are creating a calculated field that uses secured fields in a calculation, suggesting you secure the calculated field. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Field level security](../admin/field-level-security.md).  
  
<a name="BusinessScenarios"></a>   
## Calculated fields examples  
 Let’s take a look at calculated field examples in more detail. We’ll define the calculated fields with the Field Editor. To open the Field Editor:  
  
1. Open solution explorer 
  
2. Expand **Components** > **Entities**.  
  
3. Select the entity you want and choose **Fields**. Choose **New**.  
  
   In the editor, provide the required information for the field, including the **Field Type** and **Data Type**. The **Field Type** is **Calculated**. The available data types for the calculated field:  
  
- Single line of text  
  
- Option Set  
  
- Two Options  
  
- Whole Number  
  
- Decimal Number  
  
- Currency  
  
- Date and Time  
  
  The **Edit** button next to the **Field Type** takes you to the calculated field definition editor, where the new calculated field has been created, but no formula has been set. The calculated field definition consists of two sections: **CONDITION** and **ACTION**.  
  
- In the **Condition** section, you can specify an entity, field, operator, type, and value. In the dropdown box for the **Entity**, you can choose a current entity or a related entity. In the **Field** dropdown box, you have a selection of all available fields for the entity. Depending on the operator you choose, you may need to provide type and value. You can specify multiple conditions using the `AND` or `OR` operators.  
  
- In the **Action** section, you provide the formula for the calculated field.  
  
> [!NOTE]
>  You can use data from Lookup records within your Action. You first have to select the Lookup field and then type a period. After that, you can select one of the fields available on the related entity. For example, in the case of \<LookupFieldName>.\<RelatedFieldName>, you can select: ParentAccountId.AccountNumber.  
>   
>  Note that field level security will be ignored on the related entity, so if there is sensitive data in the accessed field we suggest securing your calculated field as well.  
  
### Weighted revenue of opportunity  
 In this example, we are using the fields of the opportunity entity to calculate the weighted revenue based on the opportunity’s probability. In the field editor for an opportunity entity, we create a field called “Weighted Revenue” and specify the field type as **Calculated** and the data type is **Currency**.  In the calculated field definition editor, in the **Condition** section, we specify the opportunity with the Status = Open. In the **ACTION**, the formula calculates the weighted revenue based on the opportunity estimated revenue multiplied by the probability of the opportunity.  The following screenshots show step-by-step how to define the Weighted Revenue calculated field.  
  
 **Create the calculated field called “Weighted Revenue”:**  
  
 ![Weighted revenue of Opportunity in Dynamics 365 for Customer Engagement](../customize/media/calc-field-open-opportunities.png "Weighted revenue of Opportunity in Dynamics 365 for Customer Engagement")  
  
 **Set the condition on the opportunities:**  
  
 ![Set Weighted Revenue in Dynamics 365 for Customer Engagement](../customize/media/calc-field-open-opportunity.png "Set Weighted Revenue in Dynamics 365 for Customer Engagement")  
  
 **Provide the formula for the weighted revenue:**  
  
 ![Set Weighted Revenue estimated value Dynamics 365 for Customer Engagement](../customize/media/calc-field-open-opportunities-3.png "Set Weighted Revenue estimated value Dynamics 365 for Customer Engagement")  
  
 **Altogether:**  
  
 ![Weighted revenue to est. revenue in Dynamics 365 for Customer Engagement](../customize/media/calculated-field-open-opportunity.png "Weighted revenue to est. revenue in Dynamics 365 for Customer Engagement")  
  
### Follow-up date of opportunity  
 In this example, we are using the fields of the originated lead of an opportunity, to calculate the appropriate date when to follow up on the opportunity. In the field editor for an opportunity entity, we create a field called “Follow-up date” and specify the type as **Calculated** and the data type is **Date and Time**.  In the calculated field definition editor, in the **Condition** section, we specify two conditions: the purchase time frame and the estimated value of the lead. In the **ACTION**, we provide two formulas, one, to follow up in one week on the immediate opportunity, another one, to follow up in one month, if the opportunity is not likely to happen right away. The following screenshots show step-by-step how to define the “Follow-up date” calculated field.  
  
 **Create the calculated field called “Follow-up Date”:**  
  
 ![Follow up date on an opportunity in Dynamics 365 for Customer Engagement](../customize/media/calc-field-follow-update-1.PNG "Follow up date on an opportunity in Dynamics 365 for Customer Engagement")  
  
 **Set the two conditions on the originating lead:**  
  
 ![Follow up date on an opportunity in Dynamics 365 for Customer Engagement](../customize/media/calc-field-follow-update-2.PNG "Follow up date on an opportunity in Dynamics 365 for Customer Engagement")  
  
 ![Follow up date on an opportunity in Dynamics 365 for Customer Engagement](../customize/media/calc-field-follow-update-3.PNG "Follow up date on an opportunity in Dynamics 365 for Customer Engagement")  
  
 **Provide the formula to follow up in one week:**  
  
 ![Follow up date on an opportunity in Dynamics 365 for Customer Engagement](../customize/media/calc-field-follow-update-4.PNG "Follow up date on an opportunity in Dynamics 365 for Customer Engagement")  
  
 **Provide the formula to follow up in one month:**  
  
 ![Set Follow up date in Dynamics 365 for Customer Engagement](../customize/media/calc-field-follow-update-5.PNG "Set Follow up date in Dynamics 365 for Customer Engagement")  
  
 **Altogether:**  
  
 ![Set Follow up date If&#45;Then & Else in Dynamics 365 for Customer Engagement](../customize/media/calc-field-follow-update-6.PNG "Set Follow up date If-Then & Else in Dynamics 365 for Customer Engagement")  
  
### Days from a record creation  
 In this example, we are using the **DIFFINDAYS** function, to compute the difference in days from the time when a record was created to the current date.  
  
 **Create the calculated field called “Calculated difference in days”:**  
  
 ![Create calculated field in Dynamics 365 for Customer Engagement](../customize/media/calc-field-diff-in-days-setup.png "Create calculated field in Dynamics 365 for Customer Engagement")  
  
 **Provide the formula for computing the difference in days**  
  
 ![Calculated field, DIFFINDAYS function](../customize/media/custom-calc-field-diff-days.png "Calculated field, DIFFINDAYS function")  
  
 **Altogether:**  
  
 ![Difference in days since record creation](../customize/media/calc-field-diff-days-complete.png "Difference in days since record creation")  
  
<a name="Syntax"></a>   
## Calculated field functions syntax  
 The following table contains information about the syntax for the functions provided in the **ACTION** section of the calculated field.  
  
> [!TIP]
>  The function names are specified in uppercase letters.  
  
|Function Syntax|Description|Return type|  
|---------------------|-----------------|-----------------|  
|**ADDDAYS** (whole number, date and time)|Returns a new date and time that is equal to the given date and time, plus the specified number of days.|Date and Time|  
|**ADDHOURS** (whole number, date and time)|Returns a new date and time that is equal to the given date and time, plus the specified number of hours.|Date and Time|  
|**ADDMONTHS** (whole number, date and time)|Returns a new date and time that is equal to the given date and time, plus the specified number of months.|Date and Time|  
|**ADDWEEKS** (whole number, date and time)|Returns a new date and time that is equal to the given date and time, plus the specified number of weeks.|Date and Time|  
|**ADDYEARS** (whole number, date and time)|Returns a new date and time that is equal to the given date and time, plus the specified number of years.|Date and Time|  
|**SUBTRACTDAYS** (whole number, date and time)|Returns a new date and time that is equal to the given date and time, minus the specified number of days.|Date and Time|  
|**SUBTRACTHOURS** (whole number, date and time)|Returns a new date and time that is equal to the given date and time, minus the specified number of hours.|Date and Time|  
|**SUBTRACTMONTHS** (whole number, date and time)|Returns a new date and time that is equal to the given date and time, minus the specified number of months.|Date and Time|  
|**SUBTRACTWEEKS** (whole number, date and time)|Returns a new date and time that is equal to the given date and time, minus the specified number of weeks.|Date and Time|  
|**SUBTRACTYEARS** (whole number, date and time)|Returns a new date and time that is equal to the given date and time, minus the specified number of years.|Date and Time|  
|**DIFFINDAYS** (date and time, date and time)|Returns the difference in days between two **Date and Time** fields. If both dates and times fall on the same day, the difference is zero.|Whole Number|  
|**DIFFINHOURS** (date and time, date and time)|Returns the difference in hours between two **Date and Time** fields.|Whole Number|  
|**DIFFINMINUTES** (date and time, date and time)|Returns the difference in minutes between two **Date and Time** fields.|Whole Number|  
|**DIFFINMONTHS** (date and time, date and time)|Returns the difference in months between two **Date and Time** fields. If both dates and times fall on the same month, the difference is zero.|Whole Number|  
|**DIFFINWEEKS** (date and time, date and time)|Returns the difference in weeks between two **Date and Time** fields. If both dates and times fall on the same week, the difference is zero.|Whole Number|  
|**DIFFINYEARS** (date and time, date and time)|Returns the difference in years between two **Date and Time** fields. If both dates and times fall on the same year, the difference is zero.|Whole Number|  
|**CONCAT** (single line of text, single line of text, … single line of text)|Returns a string that is the result of concatenating two or more strings.|String|  
|**TRIMLEFT** (single line of text, whole number)|Returns a string that contains a copy of a specified string without the first N-characters.|String|  
|**TRIMRIGHT** (single line of text, whole number)|Returns a string that contains a copy of a specified string without the last N-characters.|String|  
  
> [!NOTE]
>  All DIFF functions require that the first **Date and Time** field and the second **Date and Time** field have the same behavior: **User Local**, **Date Only** or **Time-Zone Independent**. If the behavior of the second field doesn’t match the behavior of the first field, the error message is shown, indicating that the second field can’t be used in the current function. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Behavior and format of the Date and Time field](../customize/behavior-format-date-time-field.md).  
> 
> [!NOTE]
>  You cannot enter a date, such as 01/01/2015, as the Date value in a calculated field. Date and DateTime values can only be set or compared using other DateTime fields.  
  
 In the **CONCAT** function, you can use literal strings as single lines of text, entity fields that contain a single line of text, or a combination of both. For example: **CONCAT** (FirstName, LastName, “is a manager.”). If a literal string contains quotation marks, precede each mark with the backslash (\\) escape character, like this: “This string contains the \”quotation marks.\”” This ensures that the quotation marks inside the string aren’t treated as special characters that separate the strings.  
  
 The following examples show how to use the **TRIMLEFT** and **TRIMRIGHT** functions. They contain the initial strings and the resulting strings, returned by the **TRIMLEFT** and **TRIMRIGHT** functions:  
  
 **TRIMLEFT** (“RXX10-3456789”, 3), returns the string “10-3456789”    
**TRIMRIGHT** (“20-3456789RXX”, 3), returns the string “20-3456789”  
  
<a name="Considerations"></a>   
## Calculated fields considerations  
 You should be aware of certain conditions and limitations when working with calculated fields:  
  
- Saved queries, charts, and visualizations can have a maximum of 10 unique calculated fields.  
  
- The calculated field values are not displayed in the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] Outlook Offline mode in the tile views or on entity main forms.  
  
- A maximum number of chained calculated fields is 5.  
  
- A calculated field can’t refer to itself or have cyclic chains.  
  
- If you change one of the condition operators in a multiple condition clause, all of the condition operators will update to that condition. For example, in the clause `IF (x > 50) OR (y ==10) OR (z < 5)`, if you change the `OR` operator to the `AND` operator, then all `OR` operators in the clause will become `AND` operators.  
  
- You can access parental fields via the Lookup field to the parent entity, such as `<LookupFieldName>.<FieldName>`. This is not possible with multi-entity Lookup fields like `Customer` which can be `Account` or `Contact`. However, some entities have individual Lookup fields for a specific entity, such as  `ParentAccountid.<FieldName>` or `ParentContactid.<FieldName>`.  
  
- Sorting is disabled on:  
  
  -   A calculated field that contains a field of a parent record.  
  
  -   A calculated field that contains a logical field (for example, address field).  
  
  -   A calculated field that contains another calculated field.  
  
- Calculated fields can span two entities only.  
  
  -   A calculated field can contain a field from another entity (spanning two entities – current entity and parent record).  
  
  -   A calculated field can’t contain a calculated field from another entity that also contains another field from a different entity (spanning three entities):   
      (Current Entity)Calculated Field <- (Parent Record) Calculated Field 1 <- (Parent Record) Calculated Field 2.  
  
- You can’t trigger workflows or plug-ins on calculated fields.  
  
- You can’t change an existing simple field to a calculated field. If your current application is using [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] or plug-ins to calculate a field, you would not be able to use the calculated fields feature without creating a new field.  
  
- Duplicate detection rules are not triggered on calculated fields.  
  
- A rollup can't reference a calculated field that uses another calculated field, even if all the fields of the other calculated field are on the current entity.  
  
### See also  
 [Create and edit fields](../customize/create-edit-fields.md#BKMK_CreatingAndEditngFields)   
 [Define rollup fields](../customize/define-rollup-fields.md)   
 [Video: Rollup and calculated fields in Dynamics CRM 2015](https://go.microsoft.com/fwlink/p/?LinkId=517727)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]