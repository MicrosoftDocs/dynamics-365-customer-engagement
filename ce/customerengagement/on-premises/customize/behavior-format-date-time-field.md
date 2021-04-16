---
title: "Behavior and format of the Date and Time field in Dynamics 365 Customer Engagement (on-premises) | MicrosoftDocs"
ms.custom: 
ms.date: 11/08/2018
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
author: Mattp123
ms.assetid: 73d691c7-344e-4c96-8979-c661c290bf81
caps.latest.revision: 47
ms.author: matp
manager: kvivek
search.audienceType: 
  - customizer

---
# Behavior and format of the Date and Time field

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Behavior and format of the date and time field](/powerapps/maker/portals/configure/behavior-format-date-time-field)

In Dynamics 365 Customer Engagement (on-premises), the Date and Time data type is used in many system entity fields. For example, you can show when an account was last used in a marketing campaign or the date and time when a case was escalated. You can also create custom entities that include the date and time fields. Depending on what the field represents, you can choose several different field behaviors: **User Local**, **Date Only** or **Time-Zone Independent**.  

<a name="Behavior"></a>   
## Date and time field behavior and format  
 The following table contains information about the date and time field behavior and format.  


|                                                                                                                                                               Behavior                                                                                                                                                               |                 Format                 |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       Changing field’s behavior                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|----------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|                        **User Local** **Note:**  This is the behavior of all date and time fields in the previous releases. <br /><br /> -   The field values are displayed in the current user’s local time.<br />-   In Web services (SDK), these values are returned using a common UTC time zone format.                         | **Date Only** - or - **Date and Time** | In the user interface (UI), you can change certain out-of-the-box entity field’s behavior from the **User Local** to **Date Only**. For a list of entities and fields, see [Changing the field behavior to Date Only on upgrade](../customize/behavior-format-date-time-field.md#ChangeBehavior). You can change the custom entity field’s behavior from the **User Local** to **Date Only** or to **Time-Zone Independent**.<br /><br /> Changing the field behavior affects the field values that are added or modified after the field behavior was changed. The existing field values remain in the database in the UTC time zone format. To change the behavior of the existing field values from UTC to Date Only, you may need a help of a developer to do it programmatically. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Convert behavior of existing date and time values in the database](../developer/behavior-format-date-time-attribute.md#convert-behavior-of-existing-date-and-time-values-in-the-database). **Warning:**  Before changing the behavior of a date and time field, you should review all the dependencies of the field, such as business rules, workflows, calculated fields, or rollup fields, to ensure that there are no issues as a result of changing the behavior. After changing the behavior of a date and time field, you should open each business rule, workflow, calculated field, and rollup field dependent on the field that you changed, review the information, and save it, to ensure that the latest date and time field’s behavior and value are used. You can restrict modifying the field’s behavior, by setting the **CanChangeDateTimeBehavior** managed property to **False**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Set managed property to change date and time behavior](../customize/behavior-format-date-time-field.md#ManagedProperty) |
| **Date Only**<br /><br /> -   The concept of a time zone isn’t applicable to this behavior. The field values are displayed without the time zone conversion.<br />-   The time portion of the value is always 12:00AM.<br />-   The date portion of the value is stored and retrieved as specified in the UI and Web services (SDK). |             **Date Only**              |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          The **Date Only** behavior can’t be changed to other behavior types, once it’s set.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
|                          **Time-Zone Independent**<br /><br /> -   The concept of a time zone isn’t applicable to this behavior. The field values are displayed without the time zone conversion.<br />-   The date and time values are stored and retrieved as specified in the UI and Web services (SDK).                          | **Date Only** - or - **Date and Time** |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    The **Time-Zone Independent** behavior can’t be changed to other behavior types, once it’s set.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
 > [!NOTE]
>  Forms only utilize the short date format as specified in personal options. The long date format is used on Charts.

> [!NOTE]
>  To create a DateTime field and specify a particular behavior, in solution explorer go to **Components** > **Entities**.  Choose the entity you want and choose **Fields**. In the field’s definition, choose **Date and Time** in the **Type** drop-down list.  

<a name="ManagedProperty"></a>   
## Set managed property to change date and time behavior  
 You can control whether or not date and time field behavior can be changed by using the **Can change date and time behavior** managed property. If you want to allow the field behavior change, you set the property to **True**, otherwise, set it to **False**.  

> [!NOTE]
>  By default, for the out-of-the-box system entity date and time fields, the **Can change date and time behavior** managed property is set to **False**. For the custom date and time fields, by default, the property is set to `True`.  

 To set the managed property, do the following:  

- Open solution explorer, go to **Components** > **Entities** and then choose a particular entity and then choose **Fields**. Choose a field. On the command bar, choose **More Actions** and in the drop-down list, choose **Managed Properties**.  

- In the **Set Managed Properties** dialog box, choose the **Can change date and time behavior** property and choose **True** or **False**. Choose **Set** to save the settings.  

  The following screenshot shows the date and time manager property.  

  ![Set managed property for Date/Time field](../customize/media/datetime-set-managed-property.PNG "Set managed property for Date/Time field")  

<a name="DateOnly"></a>   
## Date Only example: birthdays and anniversaries  
 The Date Only behavior is good for cases when information about the time of the day and the time zone isn’t required, such as birthdays or anniversaries. With this selection, all app users around the world see the exact same date value.  

 For example, Kevin and Nancy work in the Contoso Corp sales department. The system stores their customer and sales data. Kevin, based in New York (GMT-5), creates the contact record with the birthdate 4/1/1970, and assigns the record to Nancy. Nancy, based in Seattle (GMT-8), opens the record on March 31st and, because there is no time zone conversion to her local time zone, sees the contact’s correct birthdate as 4/1/1970. All other users of the system, regardless of location, see the birthdate as 4/1/1970 when they open the contact’s record  

<a name="TZI"></a>   
## Time-Zone Independent example: hotel check-in  
 You can use this behavior when time zone information isn’t required, such as the hotel check-in time. With this selection, all app users around the world see the same date and time value.  

 For example, Lisa and Rebecca work for a hotel chain that uses the app to track reservations. Lisa is based in Seattle (GMT-8). Rebecca is based in New York (GMT-5). A customer calls Lisa to book a room in one of the company’s hotels in New York City.  Lisa creates a new reservation record, sets the expected check-in time to 12/10/2014 at 11:00 AM, and saves the record. The customer arrives at the hotel in New York City at the expected time. Rebecca, at the local hotel’s front desk, views the reservation record and sees the expected check-in time as 12/10/2014 at 11:00 AM. She welcomes the customer to the hotel.  

<a name="SpecialConsiderations"></a>   
## Special considerations for date and time fields  

### All system out-of-the-box and custom date and time fields support values earlier than 1900 by default  
 The date and time fields support values as early as 1/1/1753 12:00 AM.  

### Ensuring calculated and rollup fields are valid after changing the field’s behavior  
 After changing the behavior of a calculated field or a rollup field, save the field definition to ensure the field is still valid. To save, use the field editor. In solution explorer go to **Components** > **Entities** > **Entity X** > **Fields**. On the field’s form, choose the **Edit** button next to the **Field Type** drop-down list. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Define calculated fields](../customize/define-calculated-fields.md) and [Define rollup fields](../customize/define-rollup-fields.md).  

<a name="ChangeBehavior"></a>   
### Changing the field behavior to Date Only on update  
 By default, the **Created On** and **Modified On** date and time fields for the out-of-box system entities and custom entities are set to the **User Local** behavior. The **CanChangeDateTimeBehavior** managed property for these fields is set to **False**. You can’t change the behavior for these fields.  

 By default, the following out-of-box date and time fields in are set to **Date Only** behavior, and the **CanChangeDateTimeBehavior** managed property is set to **False**.  

|Field name|Entity name|  
|----------------|-----------------|  
|Anniversary|Contact|  
|Birthdate|Contact|  
|Due Date|Invoice|  
|Est. Close Date|Lead|  
|Actual Close Date|Opportunity|  
|Est. Close Date|Opportunity|  
|Final Decision Date|Opportunity|  
|Valid From|Product|  
|Valid To|Product|  
|Closed On|Quote|  
|Due By|Quote|  

### Date and time query operators not supported for Date Only behavior  
 The following date and time related query operators are invalid for the **Date Only** behavior. The time zone conversion doesn’t occur and the time is always set at 12:00 AM. An invalid operator exception error is thrown when one of these operators is used in the query.  

- Older Than X Minutes  

- Older Than X Hours  

- Last X Hours  

- Next X Hours  

  This applies to the follow locations in the UI:  

- Advanced Find  

- Saved View Editor  

- Query Dynamics 365 Step on a Dialog  

- Outlook Client Offline Filters Editor  

- Report Wizard  

- Custom Filters on a column in Advanced Find  

### The date and time field behavior changes during a solution import  
 During a solution import, you can only change a date and time field’s behavior from **User Local** to **Date Only** or **Time Zone Independent** if you’re importing an unmanaged solution or a managed solution that owns the field.
 
 

### See also  
 [Create and edit fields](../customize/create-edit-fields.md)   
 [Define calculated fields](../customize/define-calculated-fields.md)   



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]