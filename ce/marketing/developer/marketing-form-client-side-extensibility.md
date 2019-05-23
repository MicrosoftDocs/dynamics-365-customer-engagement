---
title: "Extend Marketing forms using code(Dynamics 365 for Marketing Developer Guide) | MicrosoftDocs"
description: "Extend Marketing forms with Javascript to apply custom business logic in Dynamics 365 for Marketing."
ms.custom: 
  - dyn365-developer
  - dyn365-marketing
ms.date: 05/23/2019
ms.service: dynamics-365-marketing
ms.technology: 
  - marketing
ms.topic: conceptual
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: cfaee020-a29d-4297-8f73-e8fb378843dc
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer
search.app: 
  - D365CE
  - D365Mktg
---
# Extend Marketing forms using code

A marketing form defines a set of input fields arranged into a form layout. You'll probably build a small library of reusable forms that you can place on all your various marketing pages as needed. To add a marketing form to a specific marketing page, use a form element to position the form and choose local settings for it, which apply to that page only. More information [Marketing forms](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/marketing/marketing-forms)

Marketing forms can be extended using JavaScript to perform custom business actions in Dynamics 365 for Marketing app. Following are the methods that are available to extend marketing forms.

## Form load

Triggers when the form placeholder is recognized before the actual form content are fetched.

### Syntax

`MsCrmMkt.MsCrmFormLoader.onformload = function(formPageId) {}`

### Parameters

|Parameter Name|Type|Description|
|------|-------|----------|
|formPageId|`String`| The `msdyncrm_formpageid` value associated between particular marketing page and marketing form.|

## Form rendering

Triggers after the form content is fetched and before the form content is injected to a page.

### Syntax

`MsCrmMkt.MsCrmFormLoader.onformrender = function(formPageId) {}`

### Parameters

|Parameter Name|Type|Description|
|------|-------|----------|
|formPageId|`String`| The `msdyncrm_formpageid` value associated between particular marketing page and marketing form.|

## After form render
Triggers after the form content is injected to a page before the validation hooks are attached.

### Syntax

`MsCrmMkt.MsCrmFormLoader.afterformrender = function(formPageId) {}`

### Parameters

|Parameter Name|Type|Description|
|------|-------|----------|
|formPageId|`String`| The `msdyncrm_formpageid` value associated between particular marketing page and marketing form.|

## After form load
Triggers after the form content is injected to a page and after the validation hooks are attached.

### Syntax

`MsCrmMkt.MsCrmFormLoader.afterformload = function(formPageId) {}`

### Parameters

|Parameter Name|Type|Description|
|------|-------|----------|
|formPageId|`String`| The `msdyncrm_formpageid` value associated between particular marketing page and marketing form.|

## Form submit

Triggers on form submit before the form submission is sent to the server.

## Syntax

`MsCrmMkt.MsCrmFormLoader.onformsubmit = function(formPageId, formEvent) {}`

### Parameters

|Parameter Name|Type|Description|
|------|-------|----------|
|formPageId|`String`| The `msdyncrm_formpageid` value associated between particular marketing page and marketing form.|
|formEvent|{preventDefault:() =>void}||

## After form submit

Triggers on form submit after the form submission is sent to the server. It triggers only when the submission is successful. It triggers before the redirect or showing the confirmation message.

## Syntax

`MsCrmMkt.MsCrmFormLoader.afterformsubmit = function(formPageId) {}`

### Parameters

|Parameter Name|Type|Description|
|------|-------|----------|
|formPageId|`String`| The `msdyncrm_formpageid` value associated between particular marketing page and marketing form.|

## Add your code snippet to a marketing form
To add the JavaScript code, you need to follow the steps below:

1. Navigate to **Marketing** app and go to **Marketing forms**
2. Choose **New** to create a new marketing form.
3. Specify the **Name** and **Form type** for the marketing form and click on **Save**.
4. Click on the **Form hosting** tab and click on **...** as shown below to add a new form page.

   ![Add new form page](../media/add-existing-marketing-page.png "Add new form page")
   
5. Open the associated Marketing page and add the script in the **HTML** tab as shown below.

   ![Add code in HTML tab](../media/marketing-page-html-tab.png "Add code in HTML tab")

## Examples 

1. Sample validation - checks if the textbox is either Fabricam or Contoso, otherwise prevents the form submission.

```JS
    MsCrmMkt.MsCrmFormLoader.onformsubmit = function(formPageId, formEvent) {
  // sample validation - check if 
  document.getElementById('txt-company-name-message').style.visibility = 'hidden';
  var companyName = document.getElementById('txt-company-name').value;
  if (companyName !== 'Fabricam' && companyName != 'Contoso') {
    document.getElementById('txt-company-name-message').style.visibility = 'visible';
    formEvent.preventDefault();
  }
}
   ```
2. Filling the incoming query string parameters to hidden fields.

```JS
MsCrmMkt.MsCrmFormLoader.afterformload = function(formPageId) 
{
  var self = window.location.toString();
  var queryString = self.split("?");
  var hiddenFields = document.querySelectorAll("input[type=hidden]");
  if (queryString.length > 1) 
  {
    var pairs = queryString[1].split("&");
    for (var pairIndex in pairs) 
    {
      var pair = pairs[pairIndex].split("=");
      if (pair.length !== 2) 
      {
        continue;
      }

      var key = pair[0];
      var value = pair[1];

      if (key && value)
      {
        for (var i = 0; i < hiddenFields.length; i++) 
        {
          if (hiddenFields[i].id === key) 
          {
            hiddenFields[i].value = value;
          }
        }
      }
    }
  }
}
```

## How to implement spinner sample

1. Navigate to **Marketing Pages** and open your marketing page in which you have placed your marketing form, switch to **HTML** tab, add the following block in the **style** tag.

```css
#loaderSpinner {
    border: 16px solid #f3f3f3; /* Light grey */
    border-top: 16px solid #3498db; /* Blue */
    border-radius: 50%;
    width: 120px;
    height: 120px;
    animation: spin 2s linear infinite;
}
@keyframes spin {
    0% { transform: rotate(0deg); }
    100% { transform: rotate(360deg); }
}
```

2. In the same editor, find `data-editorblocktype="FormBlock"` tag and add the following code:

```HTML
<div id="loaderSpinner" class="wrapperContainer"></div>
<div class="wrapperContainer" data-container="true"><div data-editorblocktype="FormBlock" class="" data-form-block-id="2f516d70-f0a7-e811-a967-000d3a34a1bd"></div>
```

3. After the start of the <body> tag, add the following code:
  
  ```HTML
    <script>
     (function() {
      MsCrmMkt.MsCrmFormLoader.afterformrender = function() {
        document.getElementById("loaderSpinner").style.display = "none";
      };
    })();
    </script>  
```

