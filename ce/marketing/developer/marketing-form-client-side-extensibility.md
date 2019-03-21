---
title: "Extend Marketing forms using code(Dynamics 365 for Marketing Developer Guide) | MicrosoftDocs"
description: "Extend Marketing forms with Javascript to apply custom business logic in Dynamics 365 for Marketing."
ms.custom: 
  - dyn365-developer
  - dyn365-marketing
ms.date: 03/25/2019
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

Client-side scripting using JavaScript is one of the way to extend marketing forms to perform actions in Dynamics 365 for Marketing app. All client-side code is initiated by [events](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/developer/clientapi/events-forms-grids).

You can attach your JavaScript code to "react" to these events so that your code gets executed when the event occurs on the form. You attach your JavaScript code (scripts) to these events by using a [Script web resource](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/developer/script-jscript-web-resources) in Dynamics 365 for Customer Engagement apps.

## Form load

Triggers once the form placeholder is recognized, before the actual form content is fetched.

### Syntax

`MsCrmMkt.MsCrmFormLoader.onformload = function(formPageId) {}`

### Parameters

|Parameter Name|Type|Description|
|------|-------|----------|
|formPageId|`String`| The GUID value of the form.|

## Form rendering

Triggers after the form content is fetched and before the form content is injected into a page.

### Syntax

`MsCrmMkt.MsCrmFormLoader.onformrender = function(formPageId) {}`

### Parameters

|Parameter Name|Type|Description|
|------|-------|----------|
|formPageId|`String`| The GUID value of the form.|

## After form render
Triggers after the form content is injected into a page, before the validation hooks are attached.

### Syntax

`MsCrmMkt.MsCrmFormLoader.afterformrender = function(formPageId) {}`

### Parameters

|Parameter Name|Type|Description|
|------|-------|----------|
|formPageId|`String`| The GUID value of the form.|

## After form load
Triggers after the form content is injected into a page, and after the validation hooks are attached.

### Syntax

`MsCrmMkt.MsCrmFormLoader.afterformload = function(formPageId) {}`

### Parameters

|Parameter Name|Type|Description|
|------|-------|----------|
|formPageId|`String`| The GUID value of the form.|

## Form submit

Triggers on form submit, before the form submission is send to the server.

## Syntax

`MsCrmMkt.MsCrmFormLoader.onformsubmit = function(formPageId, formEvent) {}`

### Parameters

|Parameter Name|Type|Description|
|------|-------|----------|
|formPageId|`String`| The GUID value of the form.|
|formEvent|{preventDefault:() =>void}||

## After form submit

Triggers on form submit, after the form submission is send to the server. It triggers only in case the submission was successfull. It triggers before redirect or showing confirmation message.

## Syntax

`MsCrmMkt.MsCrmFormLoader.afterformsubmit = function(formPageId) {}`

### Parameters

|Parameter Name|Type|Description|
|------|-------|----------|
|formPageId|`String`| The GUID value of the form.|

## Examples 

1. Validating to make sure the checkbox is checked before accepting the submission.

```JavaScript
    MsCrmMkt.MsCrmFormLoader.onformsubmit = function(formPageId, formEvent) {
  // sample validation - check if 
  document.getElementById('txt-company-name-message').style.visibility = 'hidden';
  var companyName = document.getElementById('txt-company-name').value;
  if (companyName !== 'Fabricam' && companyName != 'Contosco') {
    document.getElementById('txt-company-name-message').style.visibility = 'visible';
    formEvent.preventDefault();
  }
}
   ```
2. Filling the incoming query string parameters to hidden fields.

```JavaScript
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
