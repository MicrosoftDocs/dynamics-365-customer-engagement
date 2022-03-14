---
title: "Enable custom calculation of SLA KPIs in Dynamics 365 Customer Service | MicrosoftDocs"
description: "Learn how to perform custom calculation of SLAs KPIs in Dynamics 365 Customer Service."
ms.date: 03/14/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
  - intro-internal
---

# Enable custom calculation of SLA KPIs

## Introduction

This topic describes how you can override the default time calculation.

By default, `TimeCalculation` is used to calculate the `WarningTime` and `FailureTime` of SLA KPI instances. The input parameters are **ApplicableFrom** (StartTime of type DateTime filed), **CalendarId(Guid)**, and **Duration** (warning duration or failure duration in numeric). The final `WarningTime` or `FailureTime` is calculated based on the working hours and holidays associated with the calendar.

In addition to `WarningTime` and `FailureTime`, the `ElapsedTime` is also calculated if there is a Pause and Resume scenario. The `ElapsedTime` gets added to the final `FailureTime` to ignore the working hours spend during the **Paused** state.

However, you might need a custom calculation in one of the following scenarios:
- Pause or resume scenario
- SLA changed scenario
- SLA Item is changed
- SLA KPI instance is reapplied after terminal state (applicable only on UCI SLA )

To enable custom calculation, you can define an API interface which has a fixed set of input and output parameters and add a custom logic to the time calculation. This enables a proxy setup, where the custom API is initiated and the return values are used.

## Enable custom calculation of SLA KPIs

1. Go to **Settings** > **Customization** > **Customize the system** > **Processes** > **New**.
1. On the **Create Process** dialog, enter the following:
    1. Enter a process name.
    1. From the **Category** dropdown list, select **Action** .
    1. From the **Entity** dropdown list, select **None (global)**. 
    1. Select the **New process from an existing template (select from the list)** option.
    1. Select **OK**.

    :::image type="content" source="media/cutom-time-cal-template.png" alt-text="Custom time calculation template":::
1. On the template, enable this feature for any SLA item as per requirement.

    :::image type="content" source="media/add-sla-process-arguments.png" alt-text="Enable the process arguments for any SLA item":::

1. Once toggle is Switched On, you can see the lookup for adding the Action created in step 1. Search for the associated action and save the SLA Item.
1. Implement the plugin code associated with Above Custom Action. To select the plug-in that you need, see [Plug-ins](#plug-ins).
1. AFter your plugin code is completed, link the plugin code to the previously created Custom Action.

After your changes are validated you can export the changes. 
To export:

1. Add your SLA to custom solution. This will also import your Custom Action Workflow process.
2. Include the SDK message in the solution. This also imports your plug-in.

### Plug-ins
The following are examples of plug-ins that can be used depending on the scenarios:

Scenario 1:

If there is no Pause or Resume scenarios, then only the calculation of `WarningTime` and `FailureTime` needs to be handled. Whenever any new KPI instances get created, SLA initiates the custom time calculation API to calculate only `WarningTime` and `FailureTime` in a single call.
In such a case, `requestType` will be `getEndTime` and other attributes can be fetched as defined in the following example:

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

// in this example, we are using Custom Field(new_country) on Case entity to apply the require calendar.

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
If there is a Pause or Resume scenarios, then the following scenarios need to be handled:

- calculation of elapsedTime between Pause and Resume state.
For this scenario, SLA will invoke the custom time calculation API to calculate the elapsed time between the Pause and Resumed state.
In this case requestType will be "getElapsedTime" and other attributes can be fetched as below:
- calculation of new WarningTime and FailureTime computation for resumed instances.
In this case requestType will be "getEndTime" and other attributes can be fetched as below:

```
private double CalculateElapsedTime(string regardingId, string calendarId, string slaItemId, string entityName, DateTime casePausedTime, DateTime caseResumedTime, int existingElapsedTime)
{
	OrganizationResponse customizedTimeCalculationResponse;

	// Step 1: fetch the Case Entity record	
	Entity caseRecord = FetchCaseRecord(entityName, regardingId);

	// Example 1: Override calendar at runtime: Choose Calendar based on any custom logic
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


## FAQs
For FAQs about custom time calculation of SLA KPIs, see [FAQs about custom time calculation of SLA KPIs](faqs-custom-time-sla-kpis.md#faqs-about-custom-time-calculation-of-sla-kpis).

### See also

[Define service-level agreements](define-service-level-agreements.md)  
[How SLAs are applied](define-service-level-agreements.md#how-is-the-sla-applied)  
[Enable records for SLA](enable-entities-service-level-agreements.md)  
