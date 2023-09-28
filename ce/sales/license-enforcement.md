---
title: Verify license compliance using the license checker
description: Verify and ensure that you have the appropriate Dynamics 365 license with the Dynamics 365 license checker.
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
ms.topic: conceptual
ms.collection: get-started
ms.date: 09/26/2023
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:09/26/2023
---

# Verify license compliance using the license checker

You can now use the Power Apps solution checker to verify and ensure that you have the appropriate license for the Dynamics 365 entities, operations, and controls that you're using. This feature provides an added level of clarity and accountability for businesses using Dynamics 365. It ensures that customers are paying for what they're using and helps avoid any potential compliance issues.

For more information on the Dynamics 365 sales licenses and entitlements, see the [Licensing guide](https://go.microsoft.com/fwlink/?LinkId=866544&clcid=0x409).

## How to use the license checker

The license checker rules are part of the Power Apps solution checker. As an administrator or customizer (maker), run the solution checker on your solutions before deploying them and regularly thereafter. This practice helps ensure that you have the appropriate license for the Dynamics 365 entities, operations, and controls that you're using.

[Learn more about solution checker and how to run the same](/power-apps/maker/data-platform/use-powerapps-checker).

The license checker doesn't have access to the licenses in your organization. It checks for the presence of all the entities, operations, and controls that require a Dynamics 365 Sales license, irrespective of whether you have the license or not.  

The following sections include the list of Dynamics 365 Sales entities, operations, and controls that the license checker checks for. The list is subject to change as we add more entities, operations, and controls to the licensed usage list.

## Entities and operations that require a license

The following table lists entities and the corresponding operations that require a Dynamics 365 Sales license. When you run the solution checker on your solution, it checks for the presence of restricted operations and displays a message that you must have an appropriate license to use these operations on the given entities.


|Entities  |Operations  |
|---------|---------|
|lead     | QualifyLead        |
|opportunity     |  Win, Lose, or CalculatePrice       |
|product     |   Create      |
|quote     |  GenerateQuoteFromOpportunity, Revise, Win, Close, or ConvertQuoteToSalesOrder       |
|invoice     |GenerateInvoiceFromOpportunity         |
|salesorder    |   GenerateSalesOrderFromOpportunity, Cancel, Fulfill, or  ConvertSalesOrderToInvoice      |
|msdyn_forecast     |  Create, Update, or Delete       |
|msdyn_forecastconfiguration     | Create, Update, or Delete        |
|msdyn_sequence     |  Create, Update, or Delete       |

## Controls that require a license

The following list includes controls that that require a Dynamics 365 Sales license. When you run the solution checker on your solutions, it checks for the presence of these controls and displays a message that you must have the appropriate license to use these controls.



|Plugin  |Control Name  |
|---------|---------|
|MscrmControls.AcceleratedSales.AnchorShellControl     | Sales accelerator         |
|MscrmControls.Sales.DealManagerWorkspace.DealManagerWorkspace     | Pipeline view        |
|ForecastingControls.FieldControls.ForecastGridPage     |  Forecasting grid       |
|ForecastingControls.FieldControls.CCFForecastConfig     | Forecast configuration        |
|MsdynControls.WKWControls.ConnectionsWidget     | Who knows whom widget        |
|MscrmControls.AcceleratedSales.AnchorShellGridControl     |   Focused view      |
|MscrmControls.AcceleratedSales.CadenceWidgetControl     |  Upnext widget       |
|MscrmControls.RAContainer.RAControlv2     | Relationship analytics widget        |
|MscrmControls.Sales.PredictiveScoringWidget.PredictiveScoringWidget     | Predictive lead and opportunity scoring widgets         |


## See also

[Use solution checker to validate your solutions](/power-apps/maker/data-platform/use-powerapps-checker)  