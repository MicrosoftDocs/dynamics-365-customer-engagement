---
title: "Create and edit fields in Dynamics 365 Customer Engagement | MicrosoftDocs"
ms.custom: ""
ms.date: 08/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: d88677fa-2caf-47b0-aec6-10a25a7ec9c3
caps.latest.revision: 55
ms.author: "rdubois"
manager: "brycho"
---
# Create and edit fields (attributes)
In [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], fields define the individual data items that can be used to store data in an entity. Fields are sometimes called attributes by developers. You can use the customization tools in the solution explorer to edit system fields that allow customization, or to create, edit, or delete custom entities.  
  
<a name="BKMK_CreatingAndEditngFields"></a>   
## Create and edit fields  
 Before you create a custom field, evaluate whether using an existing field meets your requirements. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create new metadata or use existing metadata](../customize/create-edit-metadata.md#BKMK_CreateNewOrUseExistingMetadata)  
  
 Part of the name of any custom field you create is the customization prefix. This is set based on the solution publisher for the solution you’re working in. If you care about the customization prefix, make sure that you are working in an unmanaged solution or the default solution where the customization prefix is the one you want for this entity. For information about how to change the customization prefix, see [Solution Publisher](../customize/customization-concepts.md#BKMK_SolutionPublisher).  
  
 You can access fields in the application in several ways:  
  
-   From the solution explorer you can expand the entity and choose the **Fields** node. From the list of fields, click **New** to create a new field or double-click any of the fields on the list to edit them.  
  
-   Expand the entity and choose the **Forms** node. Open a form in the form editor and below the **Field Explorer** click **New Field** to create a new field. For any field already added to the form you can double-click the field to display the **Field Properties**. On the **Details** tab, click **Edit**. Another way to go  to the form editor is to use the **Form** command on the command bar for any entity record.  
  
-   If you use the metadata browser tool, use the **Entity Metadata Browser** page to view details about a specific entity, and then click the **Attributes** button. If a field is editable, you can click the **Edit Attribute** button to edit the field. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use the metadata browser](../customize/create-edit-metadata.md#BKMK_MetadataBrowser).  
  
 All fields have the following properties:  
  
|Property|Description|  
|--------------|-----------------|  
|**Display Name**|The name that appears as a label in the header for lists where this attribute is included. It is also the default label when this field is shown in a form, but the label text in each form can be edited separately.|  
|**Name**|This field is pre-populated based on this **Display Name** you enter. It includes the solution publisher customization prefix. You can change the **Display Name** later, but the **Name** can’t be changed after the field is saved.|  
|**Field Requirement**|There are three options:<br /><br /> - **Optional**<br />     This field doesn’t require data to save the record.<br />- **Business Recommended**<br />     This field doesn’t require data to save the record. However a blue asterisk appears near the field to indicate it is important.<br />- **Business Required**<br />     The record can’t be saved without data in this field.<br />     Be careful when you make fields business required. People will resist using the application if they can’t save records because they lack the correct information to enter into a required field. People may enter incorrect data simply to save the record and get on with their work.<br />     You can use business rules or form scripts to change the requirement level as the data in the record changes as people work on it. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Creating and editing business rules](../customize/create-edit-business-rules.md)|  
|**Searchable**|When a field is searchable it appears in Advanced Find and is available when customizing views. Use this when there are fields for the entity that you don’t use. Setting this to **No** will reduce the number of options shown to people using advanced find.|  
|**Field Security**|For custom fields, enable this to allow this field to participate in field level security.|  
|**Auditing**|Disable this so that data in this field won’t be included with auditing data.|  
|**Description**|Set text that will appear as a tooltip when the field is displayed in a form. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Video: Microsoft Dynamics CRM Customizable Tool Tips](http://www.youtube.com/watch?v=7oqtyF6FA8E&list=PLC3591A8FE4ADBE07&index=5)|  
|**Type**|Select the type of record. Depending on the type you select, you’ll have different options. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Types of fields](../customize/create-edit-fields.md#BKMK_TypesOfFields)|  
  
 Any of the fields that provide direct text input have an **IME Mode**. The input method editor (IME) is used for East Asian languages like Japanese. IMEs allow the user to enter the thousands of different characters used in East Asian written languages using a standard 101-key keyboard.  
  
### Create or edit entity fields  
 Create new fields to capture data when existing system entities don’t have fields that meet your requirements. After you create new fields, be sure to include them on the forms and views for the entity so that they are available from the relevant [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] user interface. You can also add the new fields to reports with the following restrictions:  
  
-   Some system entities or custom entities that are included in a managed solution may not allow you to add new fields.  
  
-   Some system fields or custom fields that are included in a managed solution may not allow you to edit them.  
  
-   The default solution is a special unmanaged solution which shows you all solution components from any managed or unmanaged solutions. You can’t edit ANYTHING in the context of a managed solution. But all the things you find there are in your default solution anyway, so you don’t need to.  
  
1. [!INCLUDE[proc_permissions_system_admin](../includes/proc-permissions-system-admin.md)]  
  
2. [!INCLUDE[proc_settings_customization](../includes/proc-settings-customization.md)]  
  
3.  Click **Customize the System**.  
  
4.  Under **Components**, expand **Entities**, and then expand the entity you want.  
  
5.  Select **Fields**.  
  
    -   To add a new field, on the Actions toolbar, select **New**, and enter a **Display Name** to generate the **Name**.  
  
         \- OR -  
  
    -   To edit one or more fields, select the field or fields (using the Shift key) you want to modify and then on the Actions toolbar, select **Edit**. You can make changes to the following fields:  
  
        -   For **Field Requirement**, select whether it’s optional, recommended, or required.  
  
        -   In **Searchable**, select whether to include this field in the list of fields shown in Advanced Find for this entity and also in the field available for customizing the find columns in the Quick Find view and the Lookup view.  
  
        -   For **Field Security**, enable or disable the feature for this field.  
  
        -   For **Auditing**, enable or disable the feature for this field.  
  
    > [!NOTE]
    >  When you select multiple fields to edit, the **Edit Multiple Fields** dialog appears. You can edit **Field Requirement**, **Searchable**, and **Auditing**.  
  
6.  For new fields, under **Type**, enter the required information for the specified type. For existing fields, you cannot modify the type, but you can modify the settings for the [types of fields](../customize/create-edit-fields.md#BKMK_TypesOfFields).  
  
7.  Select the **Field type**, **Format**, and **Maximum length** of the field.  
  
8.  Select the **IME mode** for this attribute.  
  
    > [!NOTE]
    >  This specifies whether the active state of an input method editor (IME) is enabled. An IME lets you enter and edit Chinese, Japanese, and Korean characters. IMEs can be in an active or inactive state. The active state accepts Chinese, Japanese, or Korean characters. The inactive state behaves like a regular keyboard and uses a limited set of characters.  
  
9. For a new field, be sure to add a **Description** of the field – this provides instructions to your users on how to use the new field.  
  
10. Click **Save and Close**.  
  
11. Publish your customization.  
  
    -   To publish your changes for one entity, under **Components**, select **Entities**, and then the entity that you made changes to. On the Actions toolbar, select **Publish**.  
  
    -   To publish all changes you have made to multiple entities or components, on the Actions toolbar, select **Publish All Customizations**.  
  
> [!NOTE]
>  Installing a solution or publishing customizations can interfere with normal system operation. We recommend that you schedule a solution publish when it’s least disruptive to users.  
  
<a name="CreateVEfield"></a>   
## Creating a field for a virtual entity  
 Virtual entities are a special kind of entity in [!INCLUDE[pn_dyn_365](../includes/pn-dyn-365.md)] that have one or more fields containing data from an external data source. Once you have a data source record created, you can create a virtual entity by creating a custom entity and clicking the Virtual Entity option on the entity definition . For more information about how to create a virtual entity, see [Create and edit virtual entities](../customize/create-edit-virtual-entities.md).  
  
<a name="BKMK_TypesOfFields"></a>   
## Types of fields  
 The following table contains information about the field types available in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
|Field type|Description|Available field data type|  
|----------------|-----------------|-------------------------------|  
|Simple field|Contains data that is not based on a formula.|**Single Line of Text**, **Option Set**, **Two Options**, **Image**, **Whole Number**, **Floating Point Number**, **Decimal Number**, **Currency**, **Multiple Lines of Text**, **Date and Time**, **Lookup**|  
|Calculated field|Contains calculations that use fields from the current entity or related parent entities.|**Single Line of Text**, **Option Set**, **Two Options**, **Whole Number**, **Decimal Number**, **Currency**, **Date and Time**|  
|Rollup field|Contains an aggregate value computed from the records related to a record, or a value computed over a hierarchy.|**Whole Number**, **Decimal Number**, **Currency**, **Date and Time**|  
  
 The following table contains information about the field data types.  
  
|Field data type|Description|  
|---------------------|-----------------|  
|**Single Line of Text**|Up to 4000 characters of text can be in this field. You can set a maximum length to less than this. This field has several format options that will change the presentation of the text. These options are **Email**, **Text**, **Text Area**, **URL** and **Ticker Symbol** and **Phone**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Single line of text format options](../customize/create-edit-fields.md#BKMK_SingleLineofTextFormatOptions)|  
|**Multiple Lines of Text**|Up to 1,048,576 characters of text can be in this field. You can set a maximum length to less than this. When you add this field to the form you can specify the size of the field.|  
|**Option Set**|This field provides a set of options. Each option has a number value and label. When added to a form this field uses a select control and only one option can be selected. When displayed in **Advanced Find**, you can use a picklist control to select multiple options to include in your search criteria.<br /><br /> You may define a single global option set and configure multiple option set fields to use that single set of options. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Creating and editing global option sets](../customize/create-edit-global-option-sets.md)|  
|**Two Options**|This field provides two options. Each option has a number value of 0 or 1 corresponding to a false or true value. Each option also has a label so that true or false values can be represented as “Yes” and “No”, “Hot” and “Cold”, “On” and “Off” or any pair of labels you want to display.<br /><br /> Two option fields don’t provide format options at the field level. But when you add one to the form you can choose to display them as radio buttons, a check box, or a select list.|  
|**Status**|A system field that has options that generally correspond to active and inactive status. Some system attributes have additional options, but all custom attributes have only **Active** and **Inactive** status options. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Default Status and Status Reason values](../customize/default-status-and-status-reason-values.md)<br /><br /> You can also include custom state transitions to control which status options are available for certain entities. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Define status reason transitions](../customize/define-status-reason-transitions.md)|  
|**Status Reason**|A system field that has options that provide additional detail about the Status field. Each option is associated with one of the available Status options. You can add and edit the options. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Default Status and Status Reason values](../customize/default-status-and-status-reason-values.md)|  
|**Whole Number**|Integers with a value between -2,147,483,648 and 2,147,483,647 can be in this field. You can restrict the maximum or minimum values in this range. This field has format options **None**, **Duration**, **Time Zone**, and **Language** that change depending on how the field is presented. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Whole number format options](../customize/create-edit-fields.md#BKMK_WholeNummberFormatOptions)|  
|**Floating Point Number**|Up to 5 decimal points of precision can be used for values between -100,000,000,000 and -100,000,000,000 can be in this field. You can specify the level of precision and the maximum and minimum values. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Using the right type of number](../customize/create-edit-fields.md#BKMK_UsingTheRightTypeOfNumber)|  
|**Decimal Number**|Up to 10 decimal points of precision can be used for values between -100,000,000,000 and -100,000,000,000 can be in this field. You can specify the level of precision and the maximum and minimum values. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Using the right type of number](../customize/create-edit-fields.md#BKMK_UsingTheRightTypeOfNumber)|  
|**Currency**|Monetary values between -922,337,203,685,477 and 922,337,203,685,477 can be in this field. You can set a level of precision or choose to base the precision on a specific currency or a single standard precision used by the organization. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Using Currency Fields](../customize/create-edit-fields.md#BKMK_UsingCurrencyFields)|  
|**Date and Time**|This field has format options to display **Date Only** or **Date and Time**.|  
|**Image**|Each entity that supports images can have one image field. When an entity has an image field, it can be configured to display the image for the record in the application. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Image fields](../customize/create-edit-fields.md#BKMK_ImageFields), [Video: Microsoft Dynamics CRM Image Data Type](http://www.youtube.com/watch?v=4J6eCAICcDQ&list=PLC3591A8FE4ADBE07&index=7)|  
|**Lookup**|A field that allows setting a reference to a single record of a specific type of entity. Some system lookup fields behave differently. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Different types of lookups](../customize/create-edit-fields.md#BKMK_DifferentTypesOfLookups)|  
|**Owner**|A system lookup field that references the user or team that is assigned a user or team owned entity record.|  
|**Unique Identifier**|A system field stores a globally unique identifier (GUID) value for each record.|  
|**Customer**|A lookup field that you can use to specify a customer, which can be an account or contact.|  
  
### Customer field  
  
> [!NOTE]
>  This feature was introduced in [!INCLUDE[pn_crm_8_1_0_op](../includes/pn-crm-8-1-0-op.md)] and [!INCLUDE[pn_crm_8_1_0_online](../includes/pn-crm-8-1-0-online.md)].  
  
 In previous releases, several out-of-the-box entities in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)], such as the Case, Lead, and Opportunity entities, included a special kind of lookup field that represented a customer. Using this lookup field you could choose between two entities: Account or Contact. With this new capability, you can add the Customer field to any system or custom entity. You can use the Customer field in more entities to  track the customer's information  in the same way you've used the Customer field in the Case, Lead, and Opportunity entities.  
  
 Let's look at the following business scenario. Your company is an insurance provider. You use [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] to manage your customer interactions and standardize business processes. It’s important for you to know if a recipient of policies or claims is an individual or a company. To address this business requirement, you can create two custom entities: Policies and Claims.  To get and track the customer information you want, add the Customer lookup field to the Policies entity and the Claims entity, by using the new Customer field capability.  
  
<a name="BKMK_SingleLineofTextFormatOptions"></a>   
### Single line of text format options  
 The following table provides information about the format options for single line of text fields.  
  
|Format Option|Description|  
|-------------------|-----------------|  
|**Email**|The text provides a mailto link to open the user’s email application.|  
|**Text**|This option simply displays text.|  
|**Text Area**|This format option can be used to display multiple lines of text. But with a limit of 4000 characters, the Multiple Lines of Text field is a better choice if large amounts of text are expected.|  
|**URL**|The text provides a hyperlink to open the page specified. Any text that does not begin with a valid protocol will have “http://” prepended to it.<br /><br /> Only HTTP, HTTPS, FTP , FTPS, ONENOTE and TEL protocols are allowed in this field.|  
|**Ticker Symbol**|For most languages, the text will be enabled as a link to open the [MSN Money](http://money.msn.com/) website to show details about the stock price represented by the ticker symbol.<br /><br /> For certain East Asian languages the window will open [!INCLUDE[pn_bing](../includes/pn-bing.md)] search results for the ticker symbol.|  
|**Phone**|In the web application, fields will be click-enabled to initiate calls using either [!INCLUDE[pn_skype](../includes/pn-skype.md)] or [!INCLUDE[pn_Lync_Short](../includes/pn-lync-short.md)] if a client for either is installed on your computer. The telephony provider choice is at the bottom of the **General** tab of **System Settings**.<br /><br /> For [!INCLUDE[pn_moca_full](../includes/pn-moca-full.md)], [!INCLUDE[pn_skype](../includes/pn-skype.md)] is the only available telephony provider.<br /><br /> [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Video: Dynamics CRM - Phone Number Format](http://www.youtube.com/watch?v=Ti2ZbXDkiIE&list=PLC3591A8FE4ADBE07&index=6) **Important:** [!INCLUDE[cc_lync_rebranded_skype_for_business](../includes/cc-lync-rebranded-skype-for-business.md)]|  
  
<a name="BKMK_WholeNummberFormatOptions"></a>   
### Whole number format options  
 The following table provides information about the format options for whole number fields.  
  
|Format Option|Description|  
|-------------------|-----------------|  
|**None**|This option simply displays a number.|  
|**Duration**|This format option can be used to display a list of duration options. But the data stored in the database is always a number of minutes. The field looks like a drop-down list and provides suggested options like **1 minute**, **15 minutes**, **30 minutes** all the way up to **3 days**. People can choose these options. However, people can also just type in a number of minutes and it resolves to that period of time. For example, type in 60 and it resolves to 1 hour. Or they can enter “1 hour” or “2 days” and it will resolve to display that time.<br /><br /> The duration must be entered in the following format: “x minutes”, “x hours” or “x days”. Hours and days can also be entered using decimals, for example, “x.x hours” or “x.x days”.|  
|**Time Zone**|This option displays a select list of time zones such as **(GMT-12:00) International Date Line West** and **(GMT-08:00) Pacific Time (US & Canada)**. Each of these zones is stored as a number. For example, for the time zone **(GMT-08:00) Pacific Time (US & Canada)**, the TimeZoneCode is 4. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [TimeZoneCode Class (Sdk Assembly)](https://msdn.microsoft.com/library/bb959779.aspx)|  
|**Language**|This option displays a list of the languages provisioned for your organization. The values are displayed as a drop-down list of language names, but the data is stored as a number using LCID codes. [!INCLUDE[languagecode](../includes/languagecode.md)]|  
  
<a name="BKMK_UsingTheRightTypeOfNumber"></a>   
### Using the right type of number  
 When choosing the correct type of number field to use, the choice to use a **Whole Number** or **Currency** type should be pretty straightforward. The choice between using **Floating Point** or **Decimal** numbers requires more thought.  
  
 Decimal numbers are stored in the database exactly as specified. Floating point numbers store an extremely close approximation of the value. Why choose extremely close approximation when you can have the exact value? The answer is that you get different system performance.  
  
 Use decimals when you need to provide reports that require very accurate calculations, or if you typically use queries that look for values that are equal or not equal to another value.  
  
 Use floating point numbers when you store data that represents fractions or values that you will typically query comparing to another value using greater than or less than operators. In most cases, the difference between decimal and float isn’t noticeable. Unless you require the most accurate possible calculations, floating point numbers should work for you.  
  
<a name="BKMK_UsingCurrencyFields"></a>   
### Using currency fields  
 Currency fields allow for an organization to configure multiple currencies that can be used for records in the organization. When organizations have multiple currencies, they typically want to be able to perform calculations to provide values using their base currency. When you add a currency field to an entity that has no other currency fields, two additional fields are added:  
  
-   A lookup field called **Currency** that you can set to any active currency configured for your organization. You can configure multiple active currencies for your organization in **Settings** > **Business Management** > **Currencies**. There you can specify the currency and an exchange rate with the base currency set for your organization. If you have multiple active currencies, you can add the currency field to the form and allow people to specify which currency should be applied to money values for this record. This will change the currency symbol that is shown for the currency fields in the form.  
  
     Individuals can also change their personal options to select a default currency for the records they create.  
  
-   A decimal field called **Exchange Rate** that provides the exchange rate for a selected currency associated with the entity with respect to the base currency. If this field is added to the form, people can see the value, but they can’t edit it. The exchange rate is stored with the currency.  
  
 For each currency field you add, another currency field is added with the prefix “_Base” on the name. This field stores the calculation of the value of the currency field you added and the base currency. Again, if this field is added to the form, it can’t be edited.  
  
 When you configure a currency field you can choose the precision value. There are essentially three options as shown in the following table.  
  
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
## Image fields  
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
  
 Even though an entity has an image field, displaying that image in the application requires an additional step. In the entity definition the **Primary Image** field values are either **[None]** or **Entity Image**. Click **Entity Image** to display the image in the application. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Creating and editing entities](../customize/create-edit-entities.md)  
  
 When image display is enabled for an entity, any records that don’t have an image will display a placeholder image. For example, the Lead entity:  
  
 ![Placeholder image for Lead entity form in Dynamics 365](../customize/media/lead-entity-form.PNG "Placeholder image for Lead entity form in Dynamics 365")  
  
 People can choose the default image to upload a picture from their computer. Images must be less than 5120 KB and must one of the following formats:  
  
-   jpg  
  
-   jpeg  
  
-   gif  
  
-   tif  
  
-   tiff  
  
-   bmp  
  
-   png  
  
 When the image is uploaded, it will be converted to a .jpg format and all downloaded images will also use this format. If an animated .gif is uploaded, only the first frame is saved.  
  
 When an image is uploaded, it will be resized to a maximum size of 144 pixels by 144 pixels. People should resize or crop the images before they upload them so that they will display well using this size. All images are cropped to be square. If both sides of an image are smaller than 144 pixels, the image will be cropped to be a square with the dimensions of the smaller side.  
  
<a name="BKMK_DeletingFields"></a>   
## Delete fields  
 As someone with the system administrator security role, you can delete any custom fields that aren’t part of a managed solution. When you delete fields, any data stored in the fields is lost. The only way to recover data from a field that was deleted is to restore the database from a point before the field was deleted.  
  
 Before you can delete a custom entity, you must remove any dependencies that may exist in other solution components. Open the field and use the **Show Dependencies** button in the menu bar to view any **Dependent Components**. For example, if the field is used in a form or view, you must first, remove references to the field in those solution components.  
  
 If you delete a lookup field, the 1:N entity relationship for it will automatically be deleted.  
  
<a name="BKMK_SettingManagedProperties"></a>   
## Set managed properties for fields  
 [Managed properties](../customize/customization-concepts.md#BKMK_ManagedProperties) only apply when you include fields in a managed solution and import the solution into another organization. These settings allow a solution developer to have some control over the level of customization that people who install their managed solution can have when they customize this field. To set managed properties for a field, click **Managed Properties** on the menu bar.  
  
 The **Can be customized** option controls all the other options. If this option is `False`, none of the other settings apply. When it is `True`, you can specify the other customization options.  
  
 If the field is customizable, you set the following options to `True` or `False`.  
  
- **Display name can be modified**  
  
- **Can change requirement level**  
  
- **Can change Additional Properties**  
  
 These options are self-explanatory. If you set all the individual options to `False`, you might as well set **Can be customized** to `False`.  
  
### See also  
 [Entities and metadata overview](../customize/create-edit-metadata.md)   
 [Create and edit entities](../customize/create-edit-entities.md)   
 [Create and edit entity relationships](../customize/create-edit-entity-relationships.md)   
 [Create and edit global option sets](../customize/create-edit-global-option-sets.md)   
 [Default Status and Status Reason values](../customize/default-status-and-status-reason-values.md)   
 [Edit status reason transitions](../customize/define-status-reason-transitions.md#BKMK_EditStatusReasonTransitions)   
 [Set custom icon for custom case origin](../customize/set-custom-icon-custom-case-origin.md)   
 [Define rollup fields](../customize/define-rollup-fields.md)   
 [Define calculated fields](../customize/define-calculated-fields.md)   
 [Behavior and format of the date and time field](../customize/behavior-format-date-time-field.md)   
 
