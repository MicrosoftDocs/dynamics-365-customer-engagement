---
title:  Configure case and record summary on forms
description: Learn how to set up case and custom record summaries in Microsoft Dynamics 365 Customer Service.
author: gandhamm
ms.author: mgandham
ms.reviewer: gandhamm
ms.topic: how-to
ms.collection: 
ms.date: 04/15/2025
ms.custom: bap-template 
---


# Configure case and record summary on forms

Case and custom record summaries help users quickly understand the context of a case or a record and resolve customer issues more efficiently. Users can see the following summaries on forms: 

-  Case summaries appear on top of case forms, except for the following four out-of-the-box forms: Case for Interactive experience, Enhanced full case form, Case, and Case for Multisession experience forms.
- Case summaries displayed within the case form for Case for Interactive experience, Enhanced full case form, Case, and Case for Multisession experience forms, users can see the case summary within the case form.
- Record summaries appear on top of the relevant form  if custom record summary is enabled.

You can configure case and custom record summaries to appear on multiple record forms such as incident, account, or contact forms. 

## Set up msdyn_copilotsummarizationsetting parameters

You can customize the display of summaries on forms using multiple settings in the **msdyn_copilotsummarizationsetting** table. Through these configurations, you can do the following:

  - configure summaries to appear only on specific forms
  - specify which summary records must be used on which forms
  -  specify which configuration should be used as the default. 

 The following parameters are available.

### msdyn_isdefaultconfig

This setting determines which configuration should be used as the default for case and record summaries. When multiple record configurations for entities are available, the record that was created is set as the default configuration. 
  This setting can be either **True** or **False**. If the setting is set to **True** for a record, the record is used as the default configuration for all forms linked to that entity. 
  Only one record can be set to **True** at any point in time. If you set the values of all the records to **False** summary isn't displayed on the related forms for the corresponding entity.

Go to Customer Service admin center > Productivity > Summaries page and then run the following script in the Console tab of developer tools to set a record as default configuration.

    ```javascript
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

### msdyn_excludefromslist**

This setting is used to exclude specific forms from displaying summaries. You can specify the form id of the forms that you must exclude from displaying summaries. You can specify multiple ids for a record separated by commas.

For the default case summary record, the four out of the box case forms are added to the excludefromlist by default. Make sure you don't remove these forms from the list else user sees two summaries displayed on these forms.

If a form is added to the excludefromlist record of a specific entity, then record summary isn't displayed on the form. For example, if you add the form id of the case form to the excludefromlist record of the incident entity, then the case summary isn't displayed on the case form.

If you've already added the [Copilot case summary](../administer/copilot-powerapps-settings.md#display-copilot-case-summary-on-custom-case-forms) or [custom record summary](../administer/copilot-enable-custom-record-summaries.md#configure-the-summary-control-on-entity-forms) control on the corresponding custom case forms or entity forms, your users can see multiple summaries on the page. To avoid duplication, you can perform one of the following steps:

  -  To display summary on top, navigate to the required case form in Power Apps and then remove the custom summarization control.
  -  To display summary within the form, add the case form to the exception list. Run the following script in the Copilot Service admin center console to add the form to the exception list.


Go to Customer Service admin center > Productivity > Summaries page and then run the following script in the Console tab of developer tools to add forms to an exclude list.

    ```javascript
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

 This setting specifies which forms should use a particular summary configuration. This allows different forms to use different summary configurations. You can specify form IDs separated by commas to apply a specific configuration to those forms.

Go to Customer Service admin center > Productivity > Summaries page and then run the following script in the Console tab of developer tools to add a form to the applicable list of a record.


    ```javascript
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

This setting allows you to completely disable a configuration.
  If this setting is set to **True**, the record's configuration isn't displayed on any form, regardless of the applicable forms list or exclude forms list. This setting is useful for temporarily disabling a configuration without deleting it.

Go to Customer Service admin center > Productivity > Summaries page and then run the following script in the Console tab of developer tools to disable the summary for a record.

    ```javascript
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


## How it works

The system processes the settings in the following order to determine which summary record to display on which form:

1. Retrieves all summary records where msdyn_disabledforplatformsummary is set to False.
1. If the form is present in any exclude list for a specific entity, no summary is displayed at the top of that form.
1. If the form is present in an applicable list, the summary is displayed based on the configuration of the record where the form is added to the applicable list.
1. If the form isn't in any applicable list, the system uses the record where default configuration is set to True.
1. If no default configuration is set to True, no summary is displayed.
