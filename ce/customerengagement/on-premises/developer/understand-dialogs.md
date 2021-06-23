---
title: "Understand dialogs (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Dialogs contain pages, and each page can contain multiple sets of prompts and responses. You can also specify a dialog as a child dialog, and then invoke that dialog from within a parent dialog"
ms.custom: 
ms.date: 05/24/2019
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 0bdfc509-dcea-4ed2-bbac-b4836b777cbe
caps.latest.revision: 38
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Understand dialogs

Dialogs contain pages, and each page can contain multiple sets of prompts and responses. You can also specify a dialog as a *child dialog*, and then invoke that dialog from within a parent dialog. 

> [!IMPORTANT]
> [Dialogs are deprecated](/dynamics365/get-started/whats-new/customer-engagement/important-changes-coming#dialogs-are-deprecated), and should be replaced by business process flows or canvas apps in Power Apps. More information: [Replace dialogs with business process flows or canvas apps](/flow/replace-dialogs).
  
<a name="DialogComponents"></a>   
## Dialog components  
 The following diagram illustrates a sample dialog page and its components.  
  
 ![Components of a dialog](media/sample-dialog.png "Components of a dialog")  
  
 Let us look at each component in detail.  
  
<a name="Pages"></a>   
### Page  
 A page is the basic unit of a dialog, and is the visual interface for the end user. A dialog can have multiple pages, and each page can have multiple prompts and responses. When a dialog is run, these pages appear to the user in the sequence you have defined them in the dialog definition.  
  
<a name="PromptsandResponses"></a>   
### Prompt and response  
 Prompts and responses allow you to ask a question to the end user, and capture their responses. For each prompt, you have to specify a response type that defines the type of input or response control presented to the user. You can specify one of the following response types:  
  
- **None**: No response is required for the prompt. This is typically used for introductory prompts where you welcome the user.  
  
- **Single Line**: Lets you input a single line of *text*, *integer*, or *float* value. A text box is displayed for the prompt, where you can type the response.  
  
- **Radio Button**: Lets you select from a predefined set of responses, or select from the data queried from Dynamics 365 Customer Engagement (on-premises) using the `Query CRM Data` step. For example, you could choose from the following modes of communication for the new offers: email, fax, phone, or letter. Further, you can specify the data type for the responses: *text*, *integer*, or *float*. The response options are displayed as radio buttons.  
  
- **Picklist**: Lets you select from a predefined set of responses, or select from the data queried from Dynamics 365 Customer Engagement (on-premises) using the `Query CRM Data` step. However, in this case, the response options are displayed in a drop-down list.  
  
- **Multi-Line Text**: Lets you input multiple lines of *text* only. A multi-line text box is displayed for the prompt, where you can type the response.  
  
- **Date and Time**: Lets you input a date and time.  
  
- **Date Only**: Lets you input a date without a time.  
  
- **Lookup**: Lets you specify an entity record.  
  
  The user response for each `Prompt and Response` step is stored as the step variable, and can be used later in the dialog flow.  
  
  You can add a static hyperlink or dynamic hyperlink to the prompt text. While specifying a text as static hyperlink, you must specify the full URL including the communication protocol (such as http, https, and ftp). For example, if you want to create a hyperlink text called *Bing*, you must specify the URL as “<https://www.bing.com”>, and not just “www.bing.com”. Dynamic hyperlinks can be inserted into any text field. The hyperlink refers to an entity record in Dynamics 365 Customer Engagement (on-premises).  
  
  By default, each response is logged, and is available in the respective process session record. However, you can turn off response logging for a prompt and response step that contains sensitive customer information, such as credit card details, to prevent possible misuse of the data.  
  
<a name="Tips"></a>   
### Tip  
 A tip is information that you specify for each prompt and response that helps the user in responding to the prompt. Tips are optional.  
  
<a name="InputArgumentnVariable"></a>   
## Input argument and variable  
 Apart from the dialog components that were discussed earlier, there are two more components that you should be aware of in order to work with dialogs: input arguments and variables.  
  
<a name="InputArguments"></a>   
### Input argument  
 Input arguments enable data to be passed between parent and child dialogs. Input arguments are defined for child dialogs, and you can pass the values from the parent dialog by adding a **Link Child Dialog** step in the parent dialog, and then map the required responses with the input arguments in the child dialog. You can also perform simple arithmetic and string operations on input parameters using the **Assign Value** step. Input arguments can be of the following types: Single Line of Text, Whole Number, Floating Point Number, Date and Time, Date Only, or Lookup. You must also specify a default value for each of the argument types while creating them.  
  
 To illustrate the concept of input arguments in dialogs, consider the following example:  
  
-   You have a parent dialog that creates a contact by taking the following three inputs: salutation, first name, and last name.  
  
-   You have a child dialog that is used to create cases for the contacts.  
  
-   In the child dialog, you might want to have some prompts that refer to the name of the caller, which is actually stored as a prompt and response variable in the parent dialog. Additionally, you might want to set the regarding field of the cases being created to the contact record that was created using the parent dialog.  
  
-   You define the input arguments for the child dialog for all these inputs that you want from the parent record. Next, you create the parent dialog that has a **Link Child Dialog** step to invoke the child dialog, and map the correct prompt and response variables to the child dialog’s input arguments.  
  
<a name="Variables"></a>   
### Variable  
 Variables allow you to store any intermediate values such as concatenated strings or computed data as a result of simple arithmetic calculations (add, subtract, and multiply). The intermediate values are the responses that you gather while running through a series of prompts and responses in a dialog, and are stored in the respective **Prompt and Response** step variables. You can use the intermediate variables and the **Assign Value** step to perform simple arithmetic and string operations on the variables defined by you. A variable in a dialog can be of the following types: Text, Integer, Float, Date and Time, Date Only, and Lookup. You must also specify a default value for each of the variables while creating them.  
  
 To illustrate the concept of variable in dialogs, consider an example of Lead Scoring where you would like to ask a set of questions, and then calculate the score based on a formula on weighted responses. To do this, you can define an integer variable called `Score`. Then, as you collect responses, you could use the **Check Condition** step to have different weights associated with the responses, and then add, subtract, or multiply those response values to the `Score` variable using the **Assign Value** step.  
  
### Comments  
 The comments section at the bottom of a page can be used to take notes while the dialog run is in progress. This section is common for the entire process session. The user can capture information such as feedback about the dialog or the customer's comment. The comments are stored in the `Description` attribute of the process session record when the process session is finished.  
  
<a name="limitations"></a>   
## Dialog limitations  
 A link child dialog can’t be an intermediate step. You might try to split a complex dialog into child dialogs and invoke all of those child dialogs from a parent dialog. However, that is not supported in this release.  
  
 There’s a limit to the number of nested steps you can use in a dialog. The limit depends on the browser you’re using and isn’t a limit in Dynamics 365 Customer Engagement (on-premises). The nested steps are rendered in the browser as nested tables. Some browsers support more levels of nested tables than others. If the workflow designer becomes grayed out where you can’t add additional nested steps to your dialog, try the following workarounds:  
  
-   Redesign the dialog to use fewer nested steps.  
  
-   Add a child dialog to reduce the number of steps in the parent dialog.  
  
-   Use a different browser.  
  
### See also  
 [Work with Dialogs](use-dialogs-guided-processes.md)   
 [Actions on Dialogs and Dialog Sessions](actions-dialogs.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]