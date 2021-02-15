---
title: "Set up booking rules in Dynamics 365 Field Service | MicrosoftDocs"
description: Learn how to set up booking rules in Dynamics 365 Field Service.
ms.custom: 
  - dyn365-fieldservice
ms.date: 09/04/2020
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice 
ms.topic: article
author: FieldServiceDave
ms.author: daclar
manager: shellyha
search.app: 
  - D365CE
  - D365FS
---

# Set up booking rules (Field Service)

Booking rules in Field Service allow a system administrator to create warning or error messages that users see when creating or editing a resource booking record, based on custom conditions. For example, a booking rule could be created to warn a user when they attempt to book a work order to a resource on the schedule board that doesn't have the skills required for the job.  

Booking rules are custom JavaScript methods that will be executed prior to the bookable resource booking record being created or edited.  The JavaScript method can accept a parameter that will contain information for the Bookable Resource Booking record being created and must return a JavaScript object with the required properties.
 
Set up booking rules to validate a booking when it is created or modified.  
 
> [!Note]
> - Booking rules are only available for the hourly view, and not daily, weekly, or monthly views.
> - Booking rules are not available on the reassign functionality on the schedule board.

## Create a solution

The first step to setting up your booking rule is to create a custom JavaScript web resource. We recommend that you create a solution in CRM to add your custom JavaScript web resource or use an existing solution you may have for customizations.

Create CRM Solution

1. From **Settings** > **Solutions**, create a new solution for your booking rule JavaScript web resources.

The following screenshot shows a newly created solution. We recommend that your solution uses a unique publisher rather than the default publisher.

> [!div class="mx-imgBorder"]
> ![Screenshot of the booking rules for Field Service.](./media/scheduling-booking-rules-solution.png)

1. After creating the solution, select the Web Resources component and create a new web resource.
2. On the new web resource form, enter the following information:
  a. Name
  b. Display name
  c. Select **Script (Jscript)** as the type
3. Select the text editor option to enter your JavaScript code for the booking rule.
4. Select **Save** to save your web resource.
5. Select **Publish** to make sure the booking rule web resource has been published.

> [!div class="mx-imgBorder"]
> ![Screenshot of a new web resource.](./media/scheduling-booking-rules-JS.png)


## Set up a booking rule

1. From the main menu, go to **Field Service** > **Resources**, and then choose **Booking Rules** under **Booking Settings**.  

> [!div class="mx-imgBorder"]
> ![Screenshot of the active booking rules list in Field Service.](./media/scheduling-booking-rules-navigation.png)

2. Select **+New** to create a new booking rule.
3. From the booking rule form, enter the following information:
    a. Name
    b. Web resource (Select the web resource that you recently created).
    c. Enter the method name you defined in your JavaScript.

> [!div class="mx-imgBorder"]
> ![Screenshot of the booking rules.](./media/scheduling-booking-rules-new.png)

4. Save your booking rule. Once you save the booking rule, it will be used by the schedule board and schedule assistant. You can deactivate your booking rule record to keep the schedule board and schedule assistant from executing the rule.

> [!Note]
> The booking rules are currently only supported on the hourly view of the schedule board.

## Create a CRM action

In this section, we'll look at an example showing how you can use a custom CRM action to perform the validation as part of a booking rule.

When using a CRM action for the booking rule validation, you will still need to create a custom web resource as defined above. The JavaScript that you will define in your custom web resource will call the custom CRM Action and evaluate the results from the custom CRM action. See Attachment A at the end of this document for sample code that you can use to call a custom CRM action.

A custom CRM action will need to be created in CRM. We recommend that you use the CRM solution you have defined for your custom web resource to add your custom CRM action.

The custom CRM action should have the following input and output parameters. You can add additional input and output parameters as your scenario requires. You will need to ensure the JavaScript that you define to call your custom CRM action is updated to support your additional input and output parameters.

Input parameters:

- originalScheduleStart – DateTime
- originalScheduleEnd – DateTime
- originalBookableResource – EntityReference
- originalScheduleSource – Picklist
- newScheduleStart – DateTime
- newScheduleEnd – DateTime
- isCreate – Boolean
- isUpdate – Boolean

Output Parameters:

- isError – Boolean
- isWarning – Boolean
- errorMessage – String
- warningMessage - String

The following screenshot shows an example custom CRM action.  This sample is checking if the *newBookableResource* matches the preferred resource on the work order, and if the *newScheduleStart* is inside of the **Time From Promised** and **Time To Promised**.  It is assumed the dates of the promised window are for a single date. Example: Time From Promised: 01/01/2016 8:00AM / Time To Promised: 01/01/2016 12:00PM.


> [!div class="mx-imgBorder"]
> ![Screenshot of a custom CRM action](./media/scheduling-booking-rules-worflow.png)

## Sample code

The JavaScript function you created can accept a single parameter, which is considered the booking context. The passed in booking context parameter is *not* a typical CRM context used in client-side scripting.

The booking context parameter will have the following JavaScript definition. 

>[!Note]
> It's *not* necessary to include this JavaScript code in the custom web resource for the booking rule.

The possible values for *ResourceScheduleSource* are from the resource schedule source global option set. You can make use of this property to know if the booking rule is being triggered from the schedule board or scheduling assistant.

```
    var sbContext = {
    oldValues: {
        WorkOrderId: "00000000-0000-0000-0000-00000000",
        StartTime: "01/01/2016 08:00AM",
        EndTime: "01/01/2016 05:00PM",
        ResourceId: "00000000-0000-0000-0000-00000000",
        ResourceScheduleSource: 690970001
    },
    newValues: {
        WorkOrderId: "00000000-0000-0000-0000-00000000",
        StartTime: "01/01/2016 08:00AM",
        EndTime: "01/01/2016 05:00PM",
        ResourceId: "00000000-0000-0000-0000-00000000",
        ResourceScheduleSource: 690970001
    },
    isCreate: true,
    isUpdate: false
    };

```

Your validation method must return a JavaScript object with the following definition. 

>[!Note]
> It's *not* necessary to include this JavaScript code in the custom web resource for the booking rule.

```
    var ruleResult = {
    IsValid: false,
    Message: "Some Message Here",
    Type: "error" // this can be either "error" or "warning"
};
```

Example JavaScript function definition. The following JavaScript code is the only JavaScript code you'll need to include in your custom web resource.

```

    function Validate(ctx) {
      var url = Xrm.Page.context.getClientUrl();
      var ruleResult = {
  	IsValid = false;
       Message = '';
       Type = 'error';
      };

      //
      // perform some lookups or other validation logic here.
      //
  
      ruleResult.IsValid = false;
      ruleResult.Message = 'Some Error Message Here.';
      ruleResult.Type = 'error';

      return ruleResult;
    }
```

The following JavaScript can be used to call a custom CRM action that has the same input and output parameters as the previous sample.

On the booking rule record, the **Method Name** must be: *MSFSAENG.ScheduleBoard.Validate*. For reference, see the screenshot in the "Setting Up A Booking Rule" section of this article.

```

    /// <reference path="xrm.d.ts" />
    function brErrorCallback(sb) {
    // Add custom error handeling here if desired.
     return:
    function brWarningCallback(sb) {
    // Add custom warning handeling here if desired.
    return;
    }
    function brSuccessCallback(sb) {
    // add custom sucess handeling here if desired.
    return;
    }
    var MSFSAENG;
    (function (MSFSAENG) {
    MSFSAENG.ScheduleBoard = {
        url: Xrm.Page.context.getClientUrl() + "/api/data/v8.1/",
        actionName: "msfsaeng_MSFSAScheduleBoardRuleActionSample",
        actionInputParameters: function (ctx) {
            var inputParameters = {};
            if (ctx.isUpdate) {
                inputParameters = {
                    "originalScheduleStart": ctx.oldValues.StartTime,
                    "originalScheduleEnd": ctx.oldValues.EndTime,
                    "originalBookableResource": {
                        "@odata.type": "Microsoft.Dynamics.CRM.bookableresource",
                        "bookableresourceid": ctx.oldValues.ResourceId,
                        "name": ""
                    },
                    "originalScheduleSource": ctx.oldValues.ResourceScheduleSource,
                    "newScheduleStart": ctx.newValues.StartTime,
                    "newScheduleEnd": ctx.newValues.EndTime,
                    "newBookableResource": {
                        "@odata.type": "Microsoft.Dynamics.CRM.bookableresource",
                        "bookableresourceid": ctx.newValues.ResourceId,
                        "name": ""
                    },
                    "newScheduleSource": ctx.newValues.ResourceScheduleSource,
                    "isCreate": ctx.isCreate,
                    "isUpdate": ctx.isUpdate
                };
            }
            else {
                inputParameters = {
                    "newScheduleStart": ctx.newValues.StartTime,
                    "newScheduleEnd": ctx.newValues.EndTime,
                    "newBookableResource": {
                        "@odata.type": "Microsoft.Dynamics.CRM.bookableresource",
                        "bookableresourceid": ctx.newValues.ResourceId,
                        "name": ""
                    },
                    "newScheduleSource": ctx.newValues.ResourceScheduleSource,
                    "isCreate": ctx.isCreate,
                    "isUpdate": ctx.isUpdate
                };
            }
            return JSON.stringify(inputParameters);
        },
        ctx: null,
        ruleResult: {
            IsValid: true,
            Message: "",
            Type: ""
        },
        outputParameters: {
            isError: false,
            isWarning: false,
            errorMessage: "",
            warningMessage: ""
        },
        Validate: function (context) {
            this.ctx = context;
            ScheduleBoardHelper.callActionWebApi(this);
            return this.ruleResult;
        },
        errorCallback: brErrorCallback,
        warningCallback: brWarningCallback,
        successCallback: brSuccessCallback
    };
    var ScheduleBoardHelper = (function () {
        function ScheduleBoardHelper() {
        }
        ScheduleBoardHelper.callActionWebApi = function (sb) {
            var oDataEndpoint = sb.url + "msdyn_workorders(" + sb.ctx.newValues.WorkOrderId + ")/Microsoft.Dynamics.CRM." + sb.actionName;
            var req = new XMLHttpRequest();
            req.open("POST", oDataEndpoint, false);
            req.setRequestHeader("Accept", "application/json");
            req.setRequestHeader("Content-Type", "application/json; charset=utf-8");
            req.setRequestHeader("OData-MaxVersion", "4.0");
            req.setRequestHeader("OData-Version", "4.0");
            req.onreadystatechange = function () {
                if (req.readyState == 4) {
                    req.onreadystatechange = null;
                    if (req.status == 200) {
                        sb.outputParameters = JSON.parse(req.response);
                        if (sb.outputParameters.isError) {
                            sb.ruleResult.IsValid = false;
                            sb.ruleResult.Message = sb.outputParameters.errorMessage;
                            sb.ruleResult.Type = 'error';
                            if (sb.errorCallback)
                                sb.errorCallback(sb);
                            return;
                        }
                        else if (sb.outputParameters.isWarning) {
                            sb.ruleResult.IsValid = false;
                            sb.ruleResult.Message = sb.outputParameters.warningMessage;
                            sb.ruleResult.Type = 'warning';
                            if (sb.warningCallback)
                                sb.warningCallback(sb);
                            return;
                        }
                        else {
                            sb.ruleResult.IsValid = true;
                            sb.ruleResult.Message = '';
                            sb.ruleResult.Type = '';
                            if (sb.successCallback)
                                sb.successCallback(sb);
                            return;
                        }
                    }
                    else {
                        alert('Error calling Rule Action. Response = ' + req.response + ', Status = ' + req.statusText);
                    }
                }
            };
            req.send(sb.actionInputParameters(sb.ctx));
        };
        return ScheduleBoardHelper;
    }());
    })(MSFSAENG || (MSFSAENG = {}));

```

## Additional notes

- The bookable resource booking is enabled to leverage booking rules, in order to create warning or error messages that users see when creating or editing a resource booking record, based on custom conditions. As a result, business process flows can't be used on the bookable resource booking entity.

### See also    
 [Schedule within time constraints](../field-service/schedule-time-constraints.md)   
 [Set up booking statuses](../field-service/set-up-booking-statuses.md)   
 [Create and edit web resources](../customize/create-edit-web-resources.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]