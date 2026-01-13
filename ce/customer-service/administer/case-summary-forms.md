---
title: Understand auto-enabled Copilot summaries
description: Learn how to auto-enabled Copilot summaries work for case and custom record forms.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: bap-ai-copilot
ms.date: 01/14/2026
ms.update-cycle: 180-days
ms.custom: bap-template 
---

# Understand auto-enabled Copilot summaries

Case and custom record summaries help users quickly understand the context of a case or a record and resolve customer issues more efficiently. 

## Auto-enabled case summary

Case summary is automatically enabled across all out-of-the-box case forms and custom case forms. Based on the case form type, the case summary appears in different locations of the page:

-  Case summaries appear at top of case forms, except for the following four out-of-the-box forms: **Case for Interactive experience**, **Enhanced full case form**, **Case**, and **Case for Multisession experience** forms.
    - If case summary is already [enabled for custom case forms in your model-driven app](/dynamics365/customer-service/administer/copilot-powerapps-settings), users can see two summary cards on the form. 
    - If case summary isn't enabled in **Productivity** > **Summaries** page of Copilot Service admin center, the case summary feature is enabled automatically, and users see the case summary at the top of the form.
- Case summaries displayed within the case form for **Case for Interactive experience**, **Enhanced full case form**, **Case**, and **Case for Multisession experience** users can see the case summary within the case form. 
   - If the case summary is already enabled for these forms, users continue seeing the case summary within the form.
   - If the case summary isn't enabled in **Productivity** > **Summaries** page of Copilot Service admin center, the case summary feature is enabled automatically, and users see the case summary within the form.

To avoid duplication of summaries on the form or to further customize the summary, perform the steps in [Manage summarization settings](#manage-summarization-settings) section.

## Auto-enabled custom record summary

If you [configured the custom record summary](copilot-enable-custom-record-summaries.md#configure-the-custom-record-summary), custom record summaries are displayed at the top of relevant forms automatically. Users can see two custom record summaries on the form.


To avoid duplication of summaries on the form or to further customize the summary, perform the steps in [Manage summarization settings](#manage-summarization-settings) section.


## Manage summarization settings

Use multiple settings in the **msdyn_copilotsummarizationsetting** table to customize the display of summaries on the forms as follows:

- Configure summaries to appear only on specific forms.
- Specify the combination of summary records and forms that must be used.
- Specify the configuration that must be used as the default.

The following parameters are available.

### msdyn_isdefaultconfig

Determines which summary record is used as the default configuration for case and record summaries. When multiple record configurations for entities are available, the record created first is set as the default configuration. 

- This setting can be either **True** or **False**. 
- Only one record can be set to **True** at any point in time. 
- If the setting is set to **True** for a record, the record is used as the default configuration for all forms linked to that entity. 
- If you set the values of all the records to **False** summary isn't displayed on the related forms for the corresponding entity.

Go to **Copilot Service admin center** > **Productivity** > **Summaries** page and then run the following script in the Console tab of developer tools to set a record as default configuration.

```
       Xrm.WebApi.updateRecord("msdyn_copilotsummarizationsetting", "33dd33dd-ee44-ff55-aa66-77bb77bb77bb", {"msdyn_isdefaultconfig": true}).then(
    function success(result) {
        console.log("Account updated");
        // perform operations on record update
    },
    function (error) {
        console.log(error.message);
        // handle error conditions
    }
);

```

### msdyn_excludefromlist

Exclude specific forms from displaying summaries. You can specify the form ID of the forms that shouldn't  display summaries. 

- You can specify multiple IDs for a record separated by commas.
- For the default case summary record, the four out-of-the-box case forms are already added to the excludefromlist. Make sure you don't remove these forms from the list else to avoid duplication of summaries on the form.
- If a form is added to the excludefromlist of a specific entity record, then the summary isn't displayed on the form. For example, if you add the form ID of the **Information** case form to the excludefromlist of an incident record, then case summary isn't displayed on the case form.
- If you already added the [Copilot case summary](../administer/copilot-powerapps-settings.md#display-copilot-case-summary-on-custom-case-forms) or [custom record summary](../administer/copilot-enable-custom-record-summaries.md#configure-the-summary-control-on-entity-forms) control to the related forms, users might see duplicates. To avoid this perform one of the following steps:

   -  To show summaries only at the top: Remove the custom summarization control from the form in Power Apps.
   -  To show summaries only within the form: Add the form to the exclude list using the following script.

Go to **Copilot Service admin center** > **Productivity** > **Summaries** page and then run the following script in the Console tab of developer tools to add forms to an exclude list.

```
       Xrm.WebApi.updateRecord("msdyn_copilotsummarizationsetting", "33dd33dd-ee44-ff55-aa66-77bb77bb77bb",{"msdyn_excludeformslist": "66aa66aa-bb77-cc88-dd99-00ee00ee00ee"}).then(
    function success(result) {
        console.log("Account updated");
        // perform operations on record update
    },
    function (error) {
        console.log(error.message);
        // handle error conditions
    }
   );

```


### msdyn_applicableformslist

Specifies which forms should use a particular summary configuration. This allows forms to display different summary configurations. You can specify form IDs separated by commas to apply a specific configuration to those forms.

Go to **Copilot Service admin center** > **Productivity** > **Summaries**  page and then run the following script in the Console tab of developer tools to add a form to the applicable list of a record.


```
    Xrm.WebApi.updateRecord("msdyn_copilotsummarizationsetting", "33dd33dd-ee44-ff55-aa66-77bb77bb77bb", {"msdyn_applicableformslist": "66aa66aa-bb77-cc88-dd99-00ee00ee00ee"}).then(
    function success(result) {
        console.log("Account updated");
        // perform operations on record update
    },
    function (error) {
        console.log(error.message);
        // handle error conditions
    }
);

 ```

### msdyn_disabledforplatformsummary

This setting allows you to completely disable a configuration. If this setting is set to **True**, the record's configuration isn't displayed on any form, regardless of the applicable forms list or exclude forms list. This setting is useful for temporarily disabling a configuration without deleting it.

Go to **Copilot Service admin center** > **Productivity** > **Summaries**  page and then run the following script in the Console tab of developer tools to disable the summary for a record.

```
Xrm.WebApi.updateRecord("msdyn_copilotsummarizationsetting", "33dd33dd-ee44-ff55-aa66-77bb77bb77bb", {"msdyn_disabledforplatformsummary": true}).then(
    function success(result) {
        console.log("Account updated");
        // perform operations on record update
    },
    function (error) {
        console.log(error.message);
        // handle error conditions
    }
);

```

## How summaries are displayed

The system processes the settings in the following order to determine which summary record to display on which form:

1. Retrieves all summary records where `msdyn_disabledforplatformsummary` is set to **False**. If there are no records that meet this condition, no summary is displayed.
1. For the retrieved records, the system then does the following actions:
     1. Checks if the formID is added to any entity record's `msdyn_excludefromslist`. If a form is added to the exclude list, the summary isn't displayed for that form.
     1. Checks if the formID is added to any entity record's `msdyn_applicableformslist`. If the form is present in an applicable list, the summary is displayed based on the configuration of the record.
     1. Checks if the `msdyn_isdefaultconfig` is set to **True** for any entity record. If a record is set as default, the summary is displayed based on the configuration of that record.
     Summary isn't displayed if there isn't a record with `msdyn_isdefaultconfig` set to **True**.

### Related information

[Enable case summaries](/dynamics365/contact-center/administer/copilot-enable-summary#enable-case-summaries)  