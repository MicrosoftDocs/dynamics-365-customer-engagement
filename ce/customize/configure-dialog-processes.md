---
title: "Configure dialog processes in Dynamics 365 Customer Engagement | MicrosoftDocs"
ms.custom: ""
ms.date: "2017-08-31"
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: dd8d8525-acab-4bc5-a1fe-90a1aeb16b4a
caps.latest.revision: 10
ms.author: "rdubois"
manager: "brycho"
---
# Configure dialog processes
Dialogs display input forms and the data that a user needs at each step while interacting with a customer or following a complex procedure. A dialog can have branching logic that is based on input from the person stepping thourgh a case, phone call , or other customer interaction. For an overiew of dialogs, see [Dialogs overviiew](../customize/dialogs.md).

This topic shows how to configure dialogs to meet your business requirements.  
  
<a name="BKMK_DialogComponents"></a>   
## Dialog components  
 It is helpful to see what a dialog looks like to people using them before you start configuring your first one. When you open a dialog process to use it you will see a window like the one shown in the following screenshot:  
  
 ![Simple example dialog in Dynamics 365](../customize/media/dialog.PNG "Simple example dialog in Dynamics 365")  
  
 A dialog has the following components:  
  
- **Header**: Includes the name of the Dialog and the name of the current page.  
  
- **Prompt and Response**: Shows each of the prompts and responses added to the page. The prompts tell the user what to do or say, and the responses provide a place to enter data that could be used to set a value in a Dynamics 365 record or just to control the flow of the dialog. Responses are optional.  
  
- **Tip**: Provides additional detail not included in the prompt. The tip shown changes depending on which prompt has focus.  
  
- **Comments**: Use comments to capture information that will remain available as you progress through the dialog. You might want to type notes in this comments section to provide additional detail not captured in the responses.  
  
- **Help**: Opens the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] application help topic for dialogs.  
  
- **Summary**: Opens the dialog session. The Dialog session displays the data captured by the dialog. While you are using a dialog, the session will show the data set for previous pages.  
  
- **Previous**: After the first page of the dialog you can use this button to go to previous pages.  
  
- **Next**: Advances to the next dialog page.  
  
- **Finish**: After the last dialog page, this button will close the dialog with a status of completed.  
  
- **Cancel**: Closes the dialog with a status of cancelled. It is not possible to resume a cancelled dialog.  
  
 To configure a dialog after it is created you will view a page like the following screen that contains data from a **Page** containing a **Prompt and Response**.  
  
 ![Dialog configuration in Dynamics 365](../customize/media/dialog-configuration.PNG "Dialog configuration in Dynamics 365")  
  
 Like other processes, you can change the name, activate as a process template and configure the process to run as either an on-demand process or a child process. If you leave both of the **Available To Run** options unchecked when you activate the dialog, it will be set as an on-demand process.  
  
 **Input Arguments** are only used for processes that are configured to be used as a child process. For more information, see [Link child dialog](../customize/configure-dialog-processes.md#BKMK_LinkChildDialog).  
  
 Use **Variables** to set values that are stored within the dialog process. Variables are useful when a process gathers data through the course of several pages and this data may be used to perform calculations. For example, a dialog might be used to calculate a standard rating value based on the answers to several questions.  
  
<a name="BKMK_StepsAvailableForDialogs"></a>   
## Steps available for dialogs  
 Most of the steps available for dialogs are the same as those common for processes with the exception of **Page**, **Prompt and Response**, **Link Child Dialog**, and **Query Dynamics 365 Data**. See [Workflow stages and steps](../customize/configure-workflow-steps.md#BKMK_WorkflowStagesAndSteps) for details about other steps.  
  
### Prompt and response  
 **Page** is a container for **Prompt and Response** steps. You must include a **Page** before you can add a **Prompt and Response**.  
  
 The **Prompt and Response** step properties are the most important parts of the dialog. You must add at least one prompt and response step before the dialog can be activated.  
  
> [!TIP]
>  Don’t add too many Prompt and Response steps to a single page because it will require the user to scroll down the page. It is better to add additional pages so that people can click through the pages without scrolling.  
  
 After you add a prompt and response, click **Set Properties** to open the **Define Prompt and Response** dialog.  
  
 ![Configuring a Prompt and Response in Dynamics 365](../customize/media/dialog-prompt-response-config.PNG "Configuring a Prompt and Response in Dynamics 365")  
  
 A **Prompt and Response** step has the following properties:  
  
 **Statement Label**  
 The statement label should provide an appropriate heading for the Prompt Text. The **Statement Label** is visible in the dialog session when viewing the summary during or after the dialog is completed.  
  
 **Prompt Text**  
 Prompt Text may represent something the person using the dialog should say to the customer or it could include instructions about how to complete a step of a complex procedure.  
  
 **Tip Text**  
 Tip text provides additional information to support the Prompt Text.  
  
 **Response Type**  
 Choose one of the following Response Types:  
  
 **None**  
 You can add a prompt without a response.  
  
 **Single Line**  
 A single line can represent a text, integer or float data by setting the **Data Type**.  
  
 **Option Set (Radio Buttons)**  
 -   The results are presented as a set of Radio buttons. Use this option when there are just a small number of options to choose from.  
  
-   The data selected can be set to either text, integer or float data by setting the **Data Type**.  
  
-   You can choose to define static values or query Dynamics 365 Data to provide a list of options. See [Query Dynamics 365 data](../customize/configure-dialog-processes.md#BKMK_QueryCRMData) for more information.  
  
 **Options Set (Picklist)**  
 This is exactly like **Option Set (Radio Buttons)**, except that the options are displayed as a list. Use this option when there are very many options to choose from.  
  
 **Multiple Lines (Text Only)**  
 Provides an area to type text with multiple lines.  
  
 **Date and Time**  
 Provides a control to set a date and a time.  
  
 **Date Only**  
 Provides a control to set a date.  
  
 **Lookup**  
 This option will present one of the lookup fields used in the application. When you select this option the following fields appear and you must provide values for them:  
  
- **Reference Entity** : An entity that contains the lookup you want to use  
  
- **Reference Field**: The specific lookup in the reference entity that you want to use.  
  
> [!TIP]
>  If you want to have a list for an entity that has no many-to-one entity relationships, you can create a custom entity and then create a one-to-many relationship between it and the entity that you want to appear in the list. Since this custom entity has no other purpose than to allow this lookup, make sure to configure it so that it is not visible in the application and set the entity description to indicate the purpose of the entity.  
  
 **Data Type**  
 When you select a **Response Type** of **Single Line**, **Option Set (radio buttons)**, or **Option Set (picklist)**, you can choose to have the data set in the control be expressed using one of the following data types:  
  
- **Text**  
  
- **Integer**  
  
- **Float**  
  
 When you select a **Response Type** of **Lookup**, the **Data Type** field is replaced by the **Reference Entity** field.  
  
 **Log Response**  
 When you choose to not log responses you will still be able to access the responses as variables within your dialog, but the data in the response will not be saved with the dialog session. This is a security feature. Consider if you have a dialog that requires some personal information to be entered and processed. If the response is not logged it will not be saved with the dialog session record that contains the data in the dialog summary.  
  
 **Default Value**  
 Use default value to set a value to indicate that the data in the response was not provided or represents a very common response which would only need to be edited if it was different.  
  
<a name="BKMK_QueryCRMData"></a>   
### Query Dynamics 365 Data  
 If your dialog depends on the ability to display some data that is retrieved from [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] you should add a **Query Dynamics 365 Data** step before you need to view this data as either of the Option Set response types.  
  
 When you define a query you are shown a screen based on the **Advanced Find** page. You can define a new query or use one of the existing views. When any of the queries requires setting a specific value, that value is considered a variable. For example, you can create a query that shows all the Case records where a specific Account is the Customer. For the query to work, you must specify an Account Record to be the placeholder. Then, when you select the Modify Query Variables tab you will see the FetchXML representation of the query with a variable generated where you had specified a specific Account in your query.  
  
 You need to use the Form Assistant to set a slug to represent the Account record that is the context of a Dialog defined for the account entity.  
  
 ![Set Variables for querying Dynamics 365 data](../customize/media/dialog-query-data.PNG "Set Variables for querying Dynamics 365 data")  
  
 After you have done this you can Save and Close the Query. If you click the **Design New** tab at this point, your dynamic value set for this query will be removed and you will need to add it back again.  
  
 You can have a query with variables and not use a dynamic value, but then the results shown will be the same with every dialog.  
  
#### Using query variables  
 Once you have defined a query variable you will typically use in a response using the Options Set (picklist) Response Type. You can specify which of the columns in the query you want to display and some text to separate the values that are displayed on the list.  
  
 ![Setting Response details for Dynamics 365 data](../customize/media/dialog-query-data-response-details.PNG "Setting Response details for Dynamics 365 data")  
  
 The result is that in the dialog people can select from the results.  
  
 ![Results of query in a dialog in Dynamics 365](../customize/media/dialog-query-data-option-set.PNG "Results of query in a dialog in Dynamics 365")  
  
<a name="BKMK_LinkChildDialog"></a>   
## Link child dialog  
 In the same way you might use child workflows, you can also define child dialogs to create re-usable dialogs that you can re-use from other dialogs. If the child dialog has any input parameters, when you call the child dialog you need to map any available variables or responses to the input variables defined for the child dialog.  
  
### Setting input arguments for a child process  
 If you attempt to enter Input arguments for a process configured as an on-demand process, you will be prompted to change the **Available to Run** value to **As a Child process**. After you enter Input arguments, you will not be able to set the process to be an on-demand process until all the input arguments have been removed.  
  
 Input arguments can be of the following types:  
  
-   Single Line of Text  
  
-   Whole Number  
  
-   Floating Point Number  
  
-   Date and Time  
  
-   Date Only  
  
-   Lookup  
  
 With each type, you can set a default value to be used if the calling dialog doesn’t provide data to the input argument.  
  
### See also  
 [Dialogs overview](../customize/dialogs.md)   
 [Actions overview](../customize/actions.md)
