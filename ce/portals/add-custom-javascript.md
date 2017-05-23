---
title: "Use Custom JavaScript for a portal in Dynamics 365 | MicrosoftDocs"
description: ""
ms.custom: ""
ms.date: 05/22/2017
ms.service: crm-online
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: e0edf082-34bd-46aa-a8fc-e4c45a055657
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---
# Custom JavaScript
The Web Form Step record contains a field named **Custom JavaScript** that can be used to store JavaScript code to allow you to extend or modify the form's visual display or function.

The custom block of JavaScript will added to the bottom of the page just before the closing form tag element.

## Form fields

The HTML input id of an entity field is set to the logical name of the attribute. This makes selecting a field, setting values, or other client side manipulation easy with [jQuery](http://jquery.com/).  

'''$(document).ready(function() 
{
$("\#address1\_stateorprovince").val("Saskatchewan");
});
'''
## Additional client-side field validation

Sometimes you may need to customize the validation of fields on the form. The following example demonstrates adding a custom validator. This particular example forces the user to specify an email only if the another field for preferred method of contact is set to 'Email'.

**if (window.jQuery) {**

**(function ($) {**

**$(document).ready(function () {**

**if (typeof (Page\_Validators) == 'undefined') return;**

**// Create new validator**

**var newValidator = document.createElement('span');**

**newValidator.style.display = "none";**

**newValidator.id = "emailaddress1Validator";**

**newValidator.controltovalidate = "emailaddress1";**

**newValidator.errormessage = "&lt;a href='\#emailaddress1\_label'&gt;Email is a required field.&lt;/a&gt;";**

**newValidator.validationGroup = ""; // Set this if you have set ValidationGroup on the form**

**newValidator.initialvalue = "";**

**newValidator.evaluationfunction = function () {**

**var contactMethod = $("\#preferredcontactmethodcode").val();**

**if (contactMethod != 2) return true; // check if contact method is not 'Email'.**

**// only require email address if preferred contact method is email.**

**var value = $("\#emailaddress1").val();**

**if (value == null || value == "") {**

**return false;**

**} else {**

**return true;**

**}**

**};**

**// Add the new validator to the page validators array:**

**Page\_Validators.push(newValidator);**

**// Wire-up the click event handler of the validation summary link**

**$("a\[href='\#emailaddress1\_label'\]").on("click", function () { scrollToAndFocus('emailaddress1\_label','emailaddress1'); });**

**});**

**}(window.jQuery));**

**}**

## General validation

On click of the next/submit button a function named **webFormClientValidate** is executed. You can extend this method to add custom validation logic.

**if (window.jQuery) {**

**(function ($) {**

**if (typeof (webFormClientValidate) != 'undefined') {**

**var originalValidationFunction = webFormClientValidate;**

**if (originalValidationFunction && typeof (originalValidationFunction) == "function") {**

**webFormClientValidate = function() {**

**originalValidationFunction.apply(this, arguments);**

**// do your custom validation here**

**// return false; // to prevent the form submit you need to return false**

**// end custom validation.**

**return true;**

**};**

**}**

**}**

**}(window.jQuery));**

**}**

### See Also

[Configure a Dynamics 365 portal](configure-portal.md)  
[Define entity forms and custom logic within the Dynamics 365 portal](entity-forms-custom-logic.md)  
[Web Form steps for portals](web-form-steps.md)  
[Load Form/Load Tab step type](load-form-step.md)  
[Redirect step type](add-redirect-step.md)  
[Conditional step type](add-conditional-step.md)  

