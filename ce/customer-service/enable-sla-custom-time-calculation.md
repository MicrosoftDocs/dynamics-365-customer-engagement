---
title: "Enable custom calculation of SLA KPIs in Dynamics 365 Customer Service | MicrosoftDocs"
description: "Learn how to perform custom calculation of SLA KPIs in Dynamics 365 Customer Service."
ms.date: 01/17/2023
ms.topic: article
author: Soumyasd27
ms.author: sdas
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
  - intro-internal
---

# Enable custom time calculation of SLA KPIs

This article describes how you can override the default time calculation.

Time calculation in service-level agreements (SLAs) calculates the `WarningTime` and `FailureTime` of SLA key performance indicators (KPIs), taking into consideration input parameters, such as `ApplicableFrom` (StartTime of type DateTime field), `CalendarId` (GUID), and `Duration` (warning duration or failure duration in minutes). The final `WarningTime` or `FailureTime` is calculated based on the customer service schedule and the holiday schedule associated with the SLA item.

In addition to warning and failure time, the elapsed time is also calculated if there's a pause and resume scenario configured for the SLA. To ignore the working hours spent during the paused state of the SLA KPI, the elapsed time gets added to the final failure time.

To enable your own custom time calculation, define an API interface that has a fixed set of input and output parameters, and add a custom logic to calculate the time.

> [!NOTE]
> Custom time calculation is only supported as part of plug-in and not any other entity, for example, custom workflow.

## Enable custom time calculation of SLA KPIs

1. Go to [make.powerapps.com](https://make.powerapps.com).
1. Go to **Advanced Settings** > **Customizations** > **Customize the system** > **Processes** > **New**.
1. In the **Create Process** dialog, enter the following details:
    1. Enter a process name, for example, CustomPluginTime Calculation.
    1. From the **Category** dropdown list, select **Action** .
    1. From the **Entity** dropdown list, select **None (global)**. 
    1. Select the **New process from an existing template (select from the list)** option.
    1. Select the **SLACustomTimeCalculationTemplate** template from the list.
    1. Select **OK**.

    :::image type="content" source="media/custom-time-cal-template.png" alt-text="Custom time calculation template":::

1. On the template, add the required parameters (if any) and select **Activate**.

    :::image type="content" source="media/add-sla-process-arguments.png" alt-text="Enable the process arguments for any SLA item":::

1. [Write the plug-in](/powerapps/developer/data-platform/write-plug-in).

    For information on selecting the plug-in that you need, go to [Scenarios and plug-ins](#scenarios-and-plug-ins).
1. Go to the Plug-in registration tool and register the plug-in that you created with your organization, to link it to the custom action created in step 3. 

    For information on registering a plug-in, go to [Register a plug-in](/power-apps/developer/data-platform/tutorial-write-plug-in#register-plug-in).

    :::image type="content" source="media/register-plug-in.png" alt-text="Register and link the plug-in":::

1. In Customer Service admin center, add or edit the previously created custom action with the SLA Item:
    1. Set the **Allow Custom Time Calculation** toggle to **Yes**.
    1. In the **Custom Time Calculation Process** field, select the custom action created in step 3.
    1. Select **Save and Close**.

1. On the SLA form, select **Activate**, and apply it to the required entity. The warning and failure time of the SLA KPI appears in accordance with the time calculation logic provided in the custom action.

    For information on how to apply SLAs, go to [Apply SLAs](apply-slas.md#apply-slas)

1. To export the solution to another environment, first add the SLA (whose item has the custom action reference) to the custom solution. Adding the SLA will also export the custom action workflow process. Next, include the SDK message in the solution, which will export the plug-in you created earlier.

## Scenarios and plug-ins

Refer to the following scenarios and their plug-ins to implement a plug-in code associated with your custom action.

Scenario 1:

If you don't have a pause or resume scenario, only the `WarningTime` and `FailureTime` are to be calculated. Whenever any new KPI instances get created, SLA initiates the custom time calculation API to calculate only `WarningTime` and `FailureTime` in a single call.

In such a case, `requestType` will be `getEndTime`, and other attributes can be fetched as defined in the following example:

```
public void Execute(IServiceProvider serviceProvider)
{

	IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
	IOrganizationServiceFactory factory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
	_service = factory.CreateOrganizationService(context.UserId);

	// Step 1: Retrieving Input Parameters.
	string regardingId = context.InputParameters["regardingId"] as string;
	string calendarId = context.InputParameters["calendarId"] as string;
	string requestType = context.InputParameters["requestType"] as string;
	string slaItemId = context.InputParameters["slaItemId"] as string;
	string entityName = context.InputParameters["entityName"] as string;
	

	try
	{
		// implement this requestType for any new SLA KPi instance creation.
		if (requestType.Equals("getEndTime", StringComparison.CurrentCultureIgnoreCase))
		{
			int warningDuration = (int)context.InputParameters["firstInputDuration"];
			int failureDuration = (int)context.InputParameters["secondInputDuration"];
			DateTime warningStartTime = (DateTime)context.InputParameters["firstInputDate"];
			DateTime failureStartTime = (DateTime)context.InputParameters["secondInputDate"];

			// Step 2 : Add the custom Logic to calculate the WarningTime and FailureTime
			string returnCalendarId = CalculateWarningAndFailureTime(regardingId, calendarId, slaItemId, entityName, warningStartTime, failureStartTime, warningDuration, failureDuration, out DateTime warningTime, out DateTime failureTime);

			// Step 3 : return the output values.
			context.OutputParameters["firstOutputValue"] = DateTime.SpecifyKind(warningTime, DateTimeKind.Utc).ToString();
			context.OutputParameters["secondOutputValue"] = DateTime.SpecifyKind(failureTime, DateTimeKind.Utc).ToString();
			context.OutputParameters["returnCalendarId"] = returnCalendarId;			
			return;
		}

		// implement this requestType for finding Paused time for any new SLA KPi instance after it resumed.
		if (requestType.Equals("getElapsedTime", StringComparison.CurrentCultureIgnoreCase))
		{
			DateTime casePausedTime = (DateTime)context.InputParameters["firstInputDate"];
			DateTime caseResumedTime = (DateTime)context.InputParameters["secondInputDate"];
			int existingElapsedTime = (int)context.InputParameters["firstInputDuration"];
			// Step 2 : Add the custom Logic to calculate the elapsedTime between startTime(paused) and endTime(resumed)
			double elapsedTimeInMinutes = CalculateElapsedTime(regardingId, calendarId, slaItemId, entityName, casePausedTime, caseResumedTime, existingElapsedTime);

			// Step 3 : return the output values.
			context.OutputParameters["firstOutputValue"] = elapsedTimeInMinutes.ToString();
			context.OutputParameters["secondOutputValue"] = elapsedTimeInMinutes.ToString();			
			return;
		}
	} catch (Exception ex) {
		return;			
	}

	throw new Exception("Invalid requestType:" + requestType+ " for entityName:" + entityName + " of id:" + regardingId);
}

// in this example, we're using Custom Field(new_country) on the Case entity to apply the required calendar.

private string CalculateWarningAndFailureTime(string regardingId, string calendarId, string slaItemId, string entityName, DateTime warningStartTime, DateTime failureStartTime, int warningDuration, int failureDuration, out DateTime warningTime, out DateTime failureTime)
{
	OrganizationResponse customizedTimeCalculationResponse;
	warningTime = DateTime.UtcNow;
	failureTime = DateTime.UtcNow;
	int newWarningTime = warningDuration;
	int newFailureTime = failureDuration;
	int customCode = 0;

	// Step 1: fetch the Case Entity record	
	Entity caseRecord = FetchCaseRecord(entityName, regardingId);

	if (caseRecord.Attributes.Contains("new_country"))
	{
		customCode = (int)(((OptionSetValue)(caseRecord.Attributes["new_country"])).Value);

		// Example 1: Override calendar at runtime: Choose Calendar based on any custom logic
		if (customCode == 0)
		{
			// fetch IST calendar & override CalendarId
			IST_CALENDAR = FetchCalendar("IST_CALENDAR", _service);
			calendarId = IST_CALENDAR;
		}
		else if (customCode == 1)
		{
			// fetch PST calendar & override CalendarId
			PST_CALENDAR = FetchCalendar("PST_CALENDAR", _service);
			calendarId = PST_CALENDAR;
		}		
	}
	// use OOB SLATimeCalculation Custom Action to do actual calculation_
	OrganizationRequest requestTimeCalculation = new OrganizationRequest("msdyn_SLATimeCalculation");
	
	requestTimeCalculation["requestType"] = "getEndTime";
	requestTimeCalculation["calendarId"] = calendarId;

	// calculate warning time
	if (warningDuration != -1)
	{
		requestTimeCalculation["startTime"] = warningStartTime;
		requestTimeCalculation["minutes"] = newWarningTime;
		customizedTimeCalculationResponse = _service.Execute(requestTimeCalculation);
		customizedTimeCalculationResponse.Results.TryGetValue("returnValue", out object outputValue1);
		warningTime = DateTime.SpecifyKind(DateTime.Parse((string)outputValue1), DateTimeKind.Utc);
	}

	// calculate Failure time
	if (failureDuration != -1)
	{
		requestTimeCalculation["startTime"] = failureStartTime;
		requestTimeCalculation["minutes"] = newFailureTime;
		customizedTimeCalculationResponse = _service.Execute(requestTimeCalculation);
		customizedTimeCalculationResponse.Results.TryGetValue("returnValue", out object outputValue2);
		failureTime = DateTime.SpecifyKind(DateTime.Parse((string)outputValue2), DateTimeKind.Utc);				
	}

	return calendarId;
}

```

Scenario 2:

If there's a pause or resume scenario, the following calculations are to be made:

- Calculation of `elapsedTime` between paused and resumed states.
For this scenario, the SLA invokes the custom time calculation API to calculate the elapsed time between the pause and resume. In such a case, the requestType will be `getElapsedTime` and other attributes can be fetched as defined in the plug-in code example.
- Calculation of new `WarningTime` and `FailureTime` computation for resumed instances. In this case, `requestType` will be `getEndTime` and other attributes can be fetched as defined in the following example:

```
private double CalculateElapsedTime(string regardingId, string calendarId, string slaItemId, string entityName, DateTime casePausedTime, DateTime caseResumedTime, int existingElapsedTime)
{
    if (caseRecord.Attributes.Contains("new_country"))
    {
        if ((int)(((OptionSetValue)(caseRecord.Attributes["new_country"])).Value) == 0)
        {
        // fetch IST id
        IST_CALENDAR = FetchCalendar("IST_CALENDAR", _service);
        calendarId = IST_CALENDAR;
        }
        else if ((int)(((OptionSetValue)(caseRecord.Attributes["new_country"])).Value) == 1)
        {
        // fetch PST  id
        PST_CALENDAR = FetchCalendar("PST_CALENDAR", _service);
        calendarId = PST_CALENDAR;
        }
    }

	// use OOB SLATimeCalculation Custom Action to do actual calculation_
	OrganizationRequest requestTimeCalculation = new OrganizationRequest("msdyn_SLATimeCalculation");
	requestTimeCalculation["startTime"] = casePausedTime;
	requestTimeCalculation["endTime"] = caseResumedTime;
	requestTimeCalculation["requestType"] = "getElapsedTime";
	requestTimeCalculation["calendarId"] = calendarId;

	// calculate elapsed time
	customizedTimeCalculationResponse = _service.Execute(requestTimeCalculation);
	customizedTimeCalculationResponse.Results.TryGetValue("returnValue", out object outputValue1);
	double totalElapsedTime = existingElapsedTime + Double.Parse(outputValue1.ToString());
	return totalElapsedTime;
}
```

## Error codes for custom time calculation

The following are the error codes for the various error scenarios that might occur during custom time calculation.

### Error code: 10000004

Error message: "Workflow for the Custom Time Calculation API for SLA Item {0} must be active."

### Reason
The error occurs if the Custom Time Calculation Workflow is disabled.

### Resolution

When opening the SLA, you'll see a form notification along with an **Activate** button if the SLA is active but the Custom Time Calculation Workflow is disabled. To avoid this issue, make sure that the Custom Time Calculation Workflow process is always in **Active** state. Perform the SLA deployment, and then verify only after it has completed. Make sure that you don't delete or deactivate the workflow process manually or through customization.

### Error code: 10000005

Error message: "Select the Custom Time Calculation Process."

### Reason
The error occurs if the Custom Time Calculation Workflow is enabled but no workflow process action is associated with the SLA Item.

### Resolution
Add the workflow process and save the SLA item. To avoid this issue, make sure that the Custom Time Calculation Workflow process is filled in the lookup value if the toggle is set to **On**.

### Error code: 10000006

Error message: "Workflow for the Custom Time Calculation Process for SLA Item {0} is missing. {Placeholder="{0}"} refers to the SLA Item ID."

### Reason
The error occurs if the Custom Time Calculation Workflow is enabled during SLA activation and the workflow process action is associated with the SLA Item with valid GUID but the workflow is deleted.

### Resolution
You must correct the invalid workflow. Remove the existing workflow from the SLA Item, create a new workflow, and then add the new workflow to the same SLA item. To avoid this issue, make sure you don't delete any workflow manually or as part of the deployment process. Also, make sure to verify your changes before importing directly to a production environment.

### Error code: 10000007

Error message: "Plugin implementation is missing for the Custom Time Calculation Process in SLA Item {0}
{Placeholder="{0}"} refers to sla item id."

### Reason
The error occurs if the Custom Time Calculation Workflow is enabled but the associated plugin SDK messaging process step is missing or the plugin isn't registered.

### Resolution
Make sure to add the SDK step while exporting the SLA from the source or development environment. To avoid this issue, make sure that you add the SDK message step and plugin assembly in the SLA solution.

### Error code: 10000008

Error message: "Warning or the failure time returned by Custom Time Calculation Process for the SLA Item {0} is invalid. {Placeholder="{0}"} refers to sla item id."

### Reason
The error occurs if the Custom Time Calculation Workflow action returns an invalid **Failure Time** for **requestType getEndTime**.

### Resolution
You'll need to debug to find out why the custom workflow process isn't returning proper values. To avoid this issue, make sure that you add and test all the scenarios before deploying the scenarios to production. For example, this includes various SLA item applications and Pause or Resume scenarios.

### Error code: 10000009

Error message: "Elapsed Time returned by Custom Time Calculation Process for the SLA Item {0} is invalid.
{Placeholder="{0}"} refers to sla item id."

### Reason
The error occurs if the Custom Time Calculation Workflow action returns an invalid **Elapsed Time** for **requestType getElapsedTime**.

### Resolution
You'll need to debug to find out why the custom workflow process isn't returning proper values when the case was paused and resumed. To avoid this issue, make sure you add and test all the scenarios before deploying the scenarios to production. For example, this includes Pause or Resume scenarios.

### Error code: 10000010

Error message: "Workflow for the Custom Time Calculation Process {0} for SLA Item {1} is not found."

### Reason
The error occurs if the custom action for custom time calculation isn't found in the system.

### Resolution

You'll need to debug and find out if the custom action is present in the system with the same name as shown in the error. To avoid this issue, make sure that you create the same custom action name prefix as shown in the error message. You need to change the prefix of your solution or avoid exporting it as an unmanaged solution. You can also avoid creating the workflow interface directly in the managed solution, and instead create the managed solution in default customization and then add it to the solution.

## FAQ
For more information about custom time calculation of SLA KPIs, go to [FAQ about custom time calculation of SLA KPIs](faqs-custom-time-sla-kpis.md#).

### See also

[Define service-level agreements](define-service-level-agreements.md)
 
[Apply SLAs](apply-slas.md#apply-slas)
  
[Enable records for SLA](enable-entities-service-level-agreements.md)
