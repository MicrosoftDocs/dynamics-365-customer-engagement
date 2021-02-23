---
title: "Types of fields and field data types | MicrosoftDocs"
description: "Understand the different field and data types available for your app"
keywords: 
ms.date: 04/29/2019
ms.service: crm-online
ms.custom: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - powerapps
author: Mattp123
ms.assetid: 734b4ffa-5543-4f88-8517-299589f433f7
ms.author: matp
manager: kvivek
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 25
topic-status: Drafting
search.audienceType: 
  - customizer
---
# Types of fields and field data types

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Types of columns](/powerapps/maker/data-platform/types-of-fields)

<a name="BKMK_TypesOfFields"></a>

## Types of fields

The following table contains information about the field types available.  

|Field type|Description|Available field data type|  
|----------------|-----------------|-------------------------------|  
|Simple field|Contains data that is not based on a formula.|**Single Line of Text**, **Option Set**, **Two Options**, **Image**, **Whole Number**, **Floating Point Number**, **Decimal Number**, **Currency**, **Multiple Lines of Text**, **Date and Time**, **Lookup**|  
|Calculated field|Contains calculations that use fields from the current entity or related parent entities.|**Single Line of Text**, **Option Set**, **Two Options**, **Whole Number**, **Decimal Number**, **Currency**, **Date and Time**|  
|Rollup field|Contains an aggregate value computed from the records related to a record, or a value computed over a hierarchy.|**Whole Number**, **Decimal Number**, **Currency**, **Date and Time**|  

 The following table contains information about the field data types.  


|      Field data type       |                                                                                                                                                                                                                                                                                                                      Description                                                                                                                                                                                                                                                                                                                      |
|----------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|  **Single Line of Text**   |                                                                           This field can contain up to 4,000 text characters. You can set the maximum length to be less than this. This field has several format options that will change the presentation of the text. These options are **Email**, **Text**, **Text Area**, **URL**, **Ticker Symbol**, and **Phone**. More information: [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Single line of text format options](../customize/types-of-fields.md#BKMK_SingleLineofTextFormatOptions)                                                                           |
| **Multiple Lines of Text** |                                                                                                                                                                                                                                This field can contain up to 1,048,576 text characters. You can set the maximum length to be less than this. When you add this field to a form, you can specify the size of the field.                                                                                                                                                                                                                                 |
|       **Option Set**       | This field provides a set of options. Each option has a number value and label. When added to a form, this field displays a control for users to select only one option. When this field is displayed in **Advanced Find**, users can use a picklist control to select multiple options to include in their search criteria. <br /> You can define a single, global option set and configure **Option Set** fields to use that single set of options. More information: [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Creating and editing global option sets](../customize/create-edit-global-option-sets.md) |
| **MultiSelect Option Set** |           This field provides a set of options, where multiple options can be selected. When added to a form, this field uses a control for users to select multiple options. When this field is displayed in **Advanced Find**, users can select multiple options from the list to include in their search criteria. <br> You can define a single global option set and configure **MultiSelect Option Set** fields to use that single set of options. More information: [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Creating and editing global option sets](../customize/create-edit-global-option-sets.md)           |
|      **Two Options**       |                                                                             This field provides two options. Each option has a number value of 0 or 1 corresponding to a false or true value. Each option also has a label so that true or false values can be represented as “Yes” and “No”, “Hot” and “Cold”, “On” and “Off” or any pair of labels you want to display.<br /><br /> Two option fields don’t provide format options at the field level. But when you add one to the form you can choose to display them as radio buttons, a check box, or a select list.                                                                             |
|         **Status**         |                                                                 A system field that has options that generally correspond to active and inactive status. Some system attributes have additional options, but all custom attributes have only **Active** and **Inactive** status options. <br /><br /> You can also include custom state transitions to control which status options are available for certain entities. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Define status reason transitions](../customize/define-status-reason-transitions.md)                                                                  |
|     **Status Reason**      |                                                                                                                                                                                                                             A system field that has options that provide additional detail about the Status field. Each option is associated with one of the available Status options. You can add and edit the options.                                                                                                                                                                                                                              |
|      **Whole Number**      |                                                                                          Integers with a value between -2,147,483,648 and 2,147,483,647 can be in this field. You can restrict the maximum or minimum values in this range. This field has format options **None**, **Duration**, **Time Zone**, and **Language** that change depending on how the field is presented. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Whole number format options](../customize/types-of-fields.md#BKMK_WholeNummberFormatOptions)                                                                                          |
| **Floating Point Number**  |                                                                                                                                  Up to 5 decimal points of precision can be used for values between -100,000,000,000 and 100,000,000,000 can be in this field. You can specify the level of precision and the maximum and minimum values. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Using the right type of number](../customize/types-of-fields.md#BKMK_UsingTheRightTypeOfNumber)                                                                                                                                   |
|     **Decimal Number**     |                                                                                                                                  Up to 10 decimal points of precision can be used for values between -100,000,000,000 and 100,000,000,000 can be in this field. You can specify the level of precision and the maximum and minimum values. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Using the right type of number](../customize/types-of-fields.md#BKMK_UsingTheRightTypeOfNumber)                                                                                                                                  |
|        **Currency**        |                                                                                                                         Monetary values between -922,337,203,685,477 and 922,337,203,685,477 can be in this field. You can set a level of precision or choose to base the precision on a specific currency or a single standard precision used by the organization. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Using Currency Fields](../customize/types-of-fields.md#BKMK_UsingCurrencyFields)                                                                                                                         |
|     **Date and Time**      |                                                                                                                                                                                                                                                                                     This field has format options to display **Date Only** or **Date and Time**.                                                                                                                                                                                                                                                                                      |
|         **Image**          |                                                                                                        Each entity that supports images can have one image field. When an entity has an image field, it can be configured to display the image for the record in the application. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Image fields](../customize/types-of-fields.md#BKMK_ImageFields), [Video: Dynamics CRM Image Data Type](https://www.youtube.com/watch?v=4J6eCAICcDQ&list=PLC3591A8FE4ADBE07&index=7)                                                                                                         |
|         **Lookup**         |                                                                                                                                                                       A field that allows setting a reference to a single record of a specific type of entity. Some system lookup fields behave differently. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Different types of lookups](../customize/types-of-fields.md#BKMK_DifferentTypesOfLookups)                                                                                                                                                                       |
|         **Owner**          |                                                                                                                                                                                                                                                                      A system lookup field that references the user or team that is assigned a user or team owned entity record.                                                                                                                                                                                                                                                                      |
|   **Unique Identifier**    |                                                                                                                                                                                                                                                                                   A system field stores a globally unique identifier (GUID) value for each record.                                                                                                                                                                                                                                                                                    |
|        **Customer**        |                                                                                                                                                                                                                                                                              A lookup field that you can use to specify a customer, which can be an account or contact.                                                                                                                                                                                                                                                                               |

### MultiSelect Option Set
You can customize forms (main, quick create, and quick view) and email templates by adding multi-select fields. When you add a Multi-Select Option Set field, you can specify multiple values that will be available for users to select. When users fill out the form they can select one, multiple, or all the values displayed in a drop-down list.

For example, if an organization operates in multiple areas or countries, you can include multiple locations or countries in an ‘Area of operation’ field. A user can then select one or more locations from the list of available values.

Multi-select option sets can be used with read-only grids, editable grids, and most forms. Multi-select option sets can't be used with:
- Workflows, business process flows, actions, dialogs, business rules, charts, rollup fields, or calculated fields.
- Reports, SLA, or routing rules.

Multi-select fields are supported in the following types of forms:

|     Form Type      |                     Availability                      |
|--------------------|-------------------------------------------------------|
|   **Turbo form**   |                          Yes                          |
|  **Refresh form**  | Read-only (field will available but cannot be edited) |
|  **Legacy form**   |                          No                           |
| **Bulk Edit form** |                          No                           |

You can use global option sets that are defined in your organization to configure values for the multi-select option sets. For Use Existing Option Set, select Yes, and then choose an option set from the Option Set drop-down list. Also, you can perform the following action on the global option set without leaving the field creation dialog box:
- Select Edit to edit the global option set. 

    > [!NOTE]
    > You can only edit a global option set if Customizable is True. 

- Select New to create a global option set.

    ![MultiSelect Option Set](../customize/media/MultiSelect_GlobalOptionSet.png "MultiSelect option Set") 

More information: [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Creating and editing global option sets](../customize/create-edit-global-option-sets.md)

### Customer field  

 In previous releases of Dynamics 365 Customer Engagement (on-premises), several out-of-the-box entities such as the Case, Lead, and Opportunity entities, included a special kind of lookup field that represented a customer. Using this lookup field you could choose between two entities: Account or Contact. With this new capability, you can add the Customer field to any system or custom entity. You can use the Customer field in more entities to  track the customer's information  in the same way you've used the Customer field in the Case, Lead, and Opportunity entities.  

 Let's look at the following business scenario. Your company is an insurance provider. You use Dynamics 365 Customer Engagement (on-premises) to manage your customer interactions and standardize business processes. It’s important for you to know if a recipient of policies or claims is an individual or a company. To address this business requirement, you can create two custom entities: Policies and Claims.  To get and track the customer information you want, add the Customer lookup field to the Policies entity and the Claims entity, by using the new Customer field capability.  

<a name="BKMK_SingleLineofTextFormatOptions"></a>   
### Single line of text format options  
 The following table provides information about the format options for single line of text fields.  


|   Format Option   |                                                                                                                                                                                                                                                                                                                                                                                                                   Description                                                                                                                                                                                                                                                                                                                                                                                                                    |
|-------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|     **Email**     |                                                                                                                                                                                                                                                                                                                                                                                      The text provides a mailto link to open the user’s email application.                                                                                                                                                                                                                                                                                                                                                                                       |
|     **Text**      |                                                                                                                                                                                                                                                                                                                                                                                                        This option simply displays text.                                                                                                                                                                                                                                                                                                                                                                                                         |
|   **Text Area**   |                                                                                                                                                                                                                                                                                                                        This format option can be used to display multiple lines of text. But with a limit of 4000 characters, the Multiple Lines of Text field is a better choice if large amounts of text are expected.                                                                                                                                                                                                                                                                                                                         |
|      **URL**      |                                                                                                                                                                                                                                                                                                 The text provides a hyperlink to open the page specified. Any text that does not begin with a valid protocol will have “https://” prepended to it.<br /><br /> Only HTTP, HTTPS, FTP , FTPS, ONENOTE and TEL protocols are allowed in this field.                                                                                                                                                                                                                                                                                                 |
| **Ticker Symbol** |                                                                                                                                                                                                                                                    For most languages, the text will be enabled as a link to open the [MSN Money](https://money.msn.com/) website to show details about the stock price represented by the ticker symbol.<br /><br /> For certain East Asian languages the window will open [!INCLUDE[pn_bing](../includes/pn-bing.md)] search results for the ticker symbol.                                                                                                                                                                                                                                                     |
|     **Phone**     | In the web application, fields will be click-enabled to initiate calls using either [!INCLUDE[pn_skype](../includes/pn-skype.md)] or [!INCLUDE[pn_Lync_Short](../includes/pn-lync-short.md)] if a client for either is installed on your computer. The telephony provider choice is at the bottom of the **General** tab of **System Settings**.<br /><br /> For [!INCLUDE[pn_moca_full](../includes/pn-moca-full.md)], [!INCLUDE[pn_skype](../includes/pn-skype.md)] is the only available telephony provider.<br /><br /> [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Video: Dynamics CRM - Phone Number Format](https://www.youtube.com/watch?v=Ti2ZbXDkiIE&list=PLC3591A8FE4ADBE07&index=6) **Important:** [!INCLUDE[cc_lync_rebranded_skype_for_business](../includes/cc-lync-rebranded-skype-for-business.md)] |

<a name="BKMK_WholeNummberFormatOptions"></a>   
### Whole number format options  
 The following table provides information about the format options for whole number fields.  


| Format Option |                                                                                                                                                                                                                                                                                                                                                                              Description                                                                                                                                                                                                                                                                                                                                                                              |
|---------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|   **None**    |                                                                                                                                                                                                                                                                                                                                                                 This option simply displays a number.                                                                                                                                                                                                                                                                                                                                                                 |
| **Duration**  | This format option can be used to display a list of duration options. But the data stored in the database is always a number of minutes. The field looks like a drop-down list and provides suggested options like **1 minute**, **15 minutes**, **30 minutes** all the way up to **3 days**. People can choose these options. However, people can also just type in a number of minutes and it resolves to that period of time. For example, type in 60 and it resolves to 1 hour. Or they can enter “1 hour” or “2 days” and it will resolve to display that time.<br /><br /> The duration must be entered in the following format: “x minutes”, “x hours” or “x days”. Hours and days can also be entered using decimals, for example, “x.x hours” or “x.x days”.<br /><br />**NOTE:** Values must be expressible in minutes, sub-minute values will be rounded to the nearest minute.|
| **Time Zone** |                                                                                                                                                   This option displays a select list of time zones such as **(GMT-12:00) International Date Line West** and **(GMT-08:00) Pacific Time (US & Canada)**. Each of these zones is stored as a number. For example, for the time zone **(GMT-08:00) Pacific Time (US & Canada)**, the TimeZoneCode is 4. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [TimeZoneCode Class (Sdk Assembly)](https://msdn.microsoft.com/library/bb959779.aspx)                                                                                                                                                    |
| **Language**  |                                                                                                                                                                                                                                                      This option displays a list of the languages provisioned for your organization. The values are displayed as a drop-down list of language names, but the data is stored as a number using LCID codes. [!INCLUDE[languagecode](../includes/languagecode.md)]                                                                                                                                                                                                                                                       |

<a name="BKMK_UsingTheRightTypeOfNumber"></a>   
### Using the right type of number  
 When choosing the correct type of number field to use, the choice to use a **Whole Number** or **Currency** type should be pretty straightforward. The choice between using **Floating Point** or **Decimal** numbers requires more thought.  

 Decimal numbers are stored in the database exactly as specified. Floating point numbers store an extremely close approximation of the value. Why choose extremely close approximation when you can have the exact value? The answer is that you get different system performance.  

 Use decimals when you need to provide reports that require very accurate calculations, or if you typically use queries that look for values that are equal or not equal to another value.  

 Use floating point numbers when you store data that represents fractions or values that you will typically query comparing to another value using greater than or less than operators. In most cases, the difference between decimal and float isn’t noticeable. Unless you require the most accurate possible calculations, floating point numbers should work for you.  

<a name="BKMK_UsingCurrencyFields"></a>   
### Using currency fields  
 Currency fields allow for an organization to configure multiple currencies that can be used for records in the organization. When organizations have multiple currencies, they typically want to be able to perform calculations to provide values using their base currency. When you add a currency field to an entity that has no other currency fields, two additional fields are added:  

- A lookup field called **Currency** that you can set to any active currency configured for your organization. You can configure multiple active currencies for your organization in **Settings** > **Business Management** > **Currencies**. There you can specify the currency and an exchange rate with the base currency set for your organization. If you have multiple active currencies, you can add the currency field to the form and allow people to specify which currency should be applied to money values for this record. This will change the currency symbol that is shown for the currency fields in the form.  

   Individuals can also change their personal options to select a default currency for the records they create.  

- A decimal field called **Exchange Rate** that provides the exchange rate for a selected currency associated with the entity with respect to the base currency. If this field is added to the form, people can see the value, but they can’t edit it. The exchange rate is stored with the currency.  

  For each currency field you add, another currency field is added with the prefix “_Base” on the name. This field stores the calculation of the value of the currency field you added and the base currency. Again, if this field is added to the form, it can’t be edited.  

  When you configure a currency field you can choose the precision value. There are essentially three options as shown in the following table.
  > [!NOTE]
> In the Unified Interface the currency format for a negative value is set by the user settings and does not use the system setting.

|Option|Description|  
|------------|-----------------|  
|Pricing Decimal Precision|This is a single organization precision to be used for prices found in **Settings** > **Administration** > **System Settings** > **General Tab**.|  
|Currency Precision|This option applies the precision defined for the currency in the record.|  
|Specific precision values 0 – 4|These settings allow for defining a specific set precision.|  

<a name="BKMK_DifferentTypesOfLookups"></a>   
### Different types of lookups  
 When you create a new lookup field you are creating a new Many-to-One (N:1) entity relationship between the entity you’re working with and the **Target Record Type** defined for the lookup. There are additional configuration options for this relationship that are described in [Creating and editing entity relationships](../customize/create-edit-entity-relationships.md). But all custom lookups can only allow for a reference to a single record for a single target record type.  

 However, you should be aware that not every lookup behaves this way. There are several different types of system lookups as shown here.  

|Lookup type|Description|  
|-----------------|-----------------|  
|Simple|Allows for a single reference to a specific entity. All custom lookups are this type.|  
|Customer|Allows for a single reference to either an account or a contact record. These lookups are available for the Opportunity, Case, Quote, Order, and Invoice entities. These entities also have separate Account and Contact lookups that you can use if your customers are always one type. Or you can include both instead of using the Customer lookup.|  
|Owner|Allows for a single reference to either a team or a user record. All team or user-owned entities have one of these.|  
|PartyList|Allows for multiple references to multiple entities. These lookups are found on the Email entity **To** and **Cc** fields. They’re also used in the Phone and Appointment entities.|  
|Regarding|Allows for a single reference to multiple entities. These lookups are found in the regarding field used in activities.|  

<a name="BKMK_ImageFields"></a>   
### Image fields  
 Use image fields to display a single image per record in the application. Each entity can have one image field. You can add an image field to custom entities but not to system entities. The following system entities have an image field. Those marked with an asterisk are enabled by default.  

||||  
|-|-|-|  
|Account *|Article|Campaign|  
|Case|Competitor *|Connection|  
|Contact *|Contract|Currency|  
|Email Server Profile|Goal|Invoice|  
|Lead *|Mailbox|Opportunity Product|  
|Order|Organization|Product *|  
|Publisher *|Queue|Resource *|  
|Sales Literature|Territory|User*|  

 Even though an entity has an image field, displaying that image in the application requires an additional step. In the entity definition the **Primary Image** field values are either **[None]** or **Entity Image**. Select **Entity Image** to display the image in the application. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Creating and editing entities](../customize/create-edit-entities.md)  

 When image display is enabled for an entity, any records that don’t have an image will display a placeholder image. For example, the Lead entity:  

 ![Placeholder image for Lead entity form in Dynamics 365 for Customer Engagement](../customize/media/lead-entity-form.PNG "Placeholder image for Lead entity form in Dynamics 365 Customer Engagement (on-premises)")  

 People can choose the default image to upload a picture from their computer. Images must be less than 5120 KB and must one of the following formats:  

- jpg  
- jpeg  
- gif  
- tif  
- tiff  
- bmp  
- png  

  When the image is uploaded, it will be converted to a .jpg format and all downloaded images will also use this format. If an animated .gif is uploaded, only the first frame is saved.  

  When an image is uploaded, it will be resized to a maximum size of 144 pixels by 144 pixels. People should resize or crop the images before they upload them so that they will display well using this size. All images are cropped to be square. If both sides of an image are smaller than 144 pixels, the image will be cropped to be a square with the dimensions of the smaller side.  


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]