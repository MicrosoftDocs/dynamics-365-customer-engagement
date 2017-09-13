---
title: "Microsoft Dynamics 365 Customer Engagement goal EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: aba9bc0d-bb47-4fc7-965b-e206141537a4
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API goal entitytype."
---
# goal EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/goal.md](./descriptions/goal.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]goals </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Goal</td></tr>
<tr><td><b>Primary Key:</b></td><td>goalid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>title</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The goal entitytype is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|actualdecimal|Edm.Decimal|**Display Name**: Actual (Decimal)<br />**Description**: Shows the actual value (Decimal type) achieved towards the target as of the last rolled-up date. This field appears when the metric type of the goal is Amount and the amount data type is Decimal.<br />|
|actualinteger|Edm.Int32|**Display Name**: Actual (Integer)<br />**Description**: Shows the actual value (integer) achieved towards the target as of the last rolled-up date. This field appears when the metric type of the goal is Amount or Count and the amount data type is Integer.<br />|
|actualmoney|Edm.Decimal|**Display Name**: Actual (Money)<br />**Description**: Shows the actual value (Money type) achieved towards the target as of the last rolled-up date. This field appears when the metric type of the goal is Amount and the amount data type is Money.<br />|
|actualmoney_base|Edm.Decimal|**Display Name**: Actual (Money) (Base)<br />**Description**: Shows the actual value (money type) in base currency to track goal results against the target.<br />Read-only<br />|
|actualstring|Edm.String|**Display Name**: Actual<br />**Description**: Actual Value of the goal.<br />Read-only<br />|
|amountdatatype|Edm.Int32|**Display Name**: Amount Data Type<br />**Description**: Data type of the amount.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Money</td></tr><tr><td>1</td><td>Decimal</td></tr><tr><td>2</td><td>Integer</td></tr><tbody></table>|
|computedtargetasoftodaydecimal|Edm.Decimal|**Display Name**: Today's Target (Decimal)<br />**Description**: Shows the expected amount for actual value (decimal type) against the target goal.<br />Read-only<br />|
|computedtargetasoftodayinteger|Edm.Int32|**Display Name**: Today's Target (Integer)<br />**Description**: Shows the expected amount for actual value (integer type) against the target goal as of the current date.<br />Read-only<br />|
|computedtargetasoftodaymoney|Edm.Decimal|**Display Name**: Today's Target (Money)<br />**Description**: Shows the expected amount for actual value (money type) against the target goal as of the current date.<br />Read-only<br />|
|computedtargetasoftodaymoney_base|Edm.Decimal|**Display Name**: Today's Target (Money) (Base)<br />**Description**: Shows the expected amount in base currency for actual value (money type) against the target goal as of the current date.<br />Read-only<br />|
|computedtargetasoftodaypercentageachieved|Edm.Decimal|**Display Name**: Today's Target (Percentage Achieved)<br />**Description**: Shows the expected value for percentage achieved against the target goal as of the current date.<br />Read-only<br />|
|consideronlygoalownersrecords|Edm.Boolean|**Display Name**: Record Set for Rollup<br />**Description**: Select whether only the goal owner's records, or all records, should be rolled up for goal results.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Owned by goal owner</td></tr><tr><td>0</td><td>All</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|customrollupfielddecimal|Edm.Decimal|**Display Name**: Custom Rollup Field (Decimal)<br />**Description**: Indicates a placeholder rollup field for a decimal value to track a third category of results other than actuals and in-progress results.<br />|
|customrollupfieldinteger|Edm.Int32|**Display Name**: Custom Rollup Field (Integer)<br />**Description**: Indicates a placeholder rollup field for an integer value to track a third category of results other than actuals and in-progress results.<br />|
|customrollupfieldmoney|Edm.Decimal|**Display Name**: Custom Rollup Field (Money)<br />**Description**: Indicates a placeholder rollup field for a money value to track a third category of results other than actuals and in-progress results.<br />|
|customrollupfieldmoney_base|Edm.Decimal|**Display Name**: Custom Rollup Field (Money) (Base)<br />**Description**: Indicates a placeholder rollup field for a money value in base currency to track a third category of results other than actuals and in-progress results.<br />Read-only<br />|
|customrollupfieldstring|Edm.String|**Display Name**: Custom Rollup Field<br />**Description**: Placeholder rollup field for the goal.<br />Read-only<br />|
|depth|Edm.Int32|**Display Name**: Depth<br />**Description**: Depth of the goal in the tree.<br />Read-only<br />|
|entityimage|Edm.Binary|**Display Name**: Entity Image<br />**Description**: The default image for the entity.<br />|
|entityimage_timestamp|Edm.Int64|Read-only<br />|
|entityimage_url|Edm.String|Read-only<br />|
|entityimageid|Edm.Guid|**Display Name**: Entity Image Id<br />**Description**: For internal use only.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />Read-only<br />|
|fiscalperiod|Edm.Int32|**Display Name**: Fiscal Period<br />**Description**: Select the fiscal period for the goal.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Quarter 1</td></tr><tr><td>2</td><td>Quarter 2</td></tr><tr><td>3</td><td>Quarter 3</td></tr><tr><td>4</td><td>Quarter 4</td></tr><tr><td>101</td><td>January</td></tr><tr><td>102</td><td>February</td></tr><tr><td>103</td><td>March</td></tr><tr><td>104</td><td>April</td></tr><tr><td>105</td><td>May</td></tr><tr><td>106</td><td>June</td></tr><tr><td>107</td><td>July</td></tr><tr><td>108</td><td>August</td></tr><tr><td>109</td><td>September</td></tr><tr><td>110</td><td>October</td></tr><tr><td>111</td><td>November</td></tr><tr><td>112</td><td>December</td></tr><tr><td>201</td><td>Semester 1</td></tr><tr><td>202</td><td>Semester 2</td></tr><tr><td>301</td><td>Annual</td></tr><tr><td>401</td><td>P1</td></tr><tr><td>402</td><td>P2</td></tr><tr><td>403</td><td>P3</td></tr><tr><td>404</td><td>P4</td></tr><tr><td>405</td><td>P5</td></tr><tr><td>406</td><td>P6</td></tr><tr><td>407</td><td>P7</td></tr><tr><td>408</td><td>P8</td></tr><tr><td>409</td><td>P9</td></tr><tr><td>410</td><td>P10</td></tr><tr><td>411</td><td>P11</td></tr><tr><td>412</td><td>P12</td></tr><tr><td>413</td><td>P13</td></tr><tbody></table>|
|fiscalyear|Edm.Int32|**Display Name**: Fiscal Year<br />**Description**: Select the fiscal year for the goal that's being tracked.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>2038</td><td>FY2038</td></tr><tr><td>2037</td><td>FY2037</td></tr><tr><td>2036</td><td>FY2036</td></tr><tr><td>2035</td><td>FY2035</td></tr><tr><td>2034</td><td>FY2034</td></tr><tr><td>2033</td><td>FY2033</td></tr><tr><td>2032</td><td>FY2032</td></tr><tr><td>2031</td><td>FY2031</td></tr><tr><td>2030</td><td>FY2030</td></tr><tr><td>2029</td><td>FY2029</td></tr><tr><td>2028</td><td>FY2028</td></tr><tr><td>2027</td><td>FY2027</td></tr><tr><td>2026</td><td>FY2026</td></tr><tr><td>2025</td><td>FY2025</td></tr><tr><td>2024</td><td>FY2024</td></tr><tr><td>2023</td><td>FY2023</td></tr><tr><td>2022</td><td>FY2022</td></tr><tr><td>2021</td><td>FY2021</td></tr><tr><td>2020</td><td>FY2020</td></tr><tr><td>2019</td><td>FY2019</td></tr><tr><td>2018</td><td>FY2018</td></tr><tr><td>2017</td><td>FY2017</td></tr><tr><td>2016</td><td>FY2016</td></tr><tr><td>2015</td><td>FY2015</td></tr><tr><td>2014</td><td>FY2014</td></tr><tr><td>2013</td><td>FY2013</td></tr><tr><td>2012</td><td>FY2012</td></tr><tr><td>2011</td><td>FY2011</td></tr><tr><td>2010</td><td>FY2010</td></tr><tr><td>2009</td><td>FY2009</td></tr><tr><td>2008</td><td>FY2008</td></tr><tr><td>2007</td><td>FY2007</td></tr><tr><td>2006</td><td>FY2006</td></tr><tr><td>2005</td><td>FY2005</td></tr><tr><td>2004</td><td>FY2004</td></tr><tr><td>2003</td><td>FY2003</td></tr><tr><td>2002</td><td>FY2002</td></tr><tr><td>2001</td><td>FY2001</td></tr><tr><td>2000</td><td>FY2000</td></tr><tr><td>1999</td><td>FY1999</td></tr><tr><td>1998</td><td>FY1998</td></tr><tr><td>1997</td><td>FY1997</td></tr><tr><td>1996</td><td>FY1996</td></tr><tr><td>1995</td><td>FY1995</td></tr><tr><td>1994</td><td>FY1994</td></tr><tr><td>1993</td><td>FY1993</td></tr><tr><td>1992</td><td>FY1992</td></tr><tr><td>1991</td><td>FY1991</td></tr><tr><td>1990</td><td>FY1990</td></tr><tr><td>1989</td><td>FY1989</td></tr><tr><td>1988</td><td>FY1988</td></tr><tr><td>1987</td><td>FY1987</td></tr><tr><td>1986</td><td>FY1986</td></tr><tr><td>1985</td><td>FY1985</td></tr><tr><td>1984</td><td>FY1984</td></tr><tr><td>1983</td><td>FY1983</td></tr><tr><td>1982</td><td>FY1982</td></tr><tr><td>1981</td><td>FY1981</td></tr><tr><td>1980</td><td>FY1980</td></tr><tr><td>1979</td><td>FY1979</td></tr><tr><td>1978</td><td>FY1978</td></tr><tr><td>1977</td><td>FY1977</td></tr><tr><td>1976</td><td>FY1976</td></tr><tr><td>1975</td><td>FY1975</td></tr><tr><td>1974</td><td>FY1974</td></tr><tr><td>1973</td><td>FY1973</td></tr><tr><td>1972</td><td>FY1972</td></tr><tr><td>1971</td><td>FY1971</td></tr><tr><td>1970</td><td>FY1970</td></tr><tbody></table>|
|goalenddate|Edm.DateTimeOffset|**Display Name**: To<br />**Description**: Enter the date when the goal ends.<br />|
|goalid|Edm.Guid|**Display Name**: Goal<br />**Description**: Unique identifier of the goal.<br />|
|goalstartdate|Edm.DateTimeOffset|**Display Name**: From<br />**Description**: Enter the date and time when the period for tracking the goal begins.<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|inprogressdecimal|Edm.Decimal|**Display Name**: In-progress (Decimal)<br />**Description**: Shows the in-progress value (decimal) against the target. This value could contribute to a goal, but is not counted yet as actual.<br />|
|inprogressinteger|Edm.Int32|**Display Name**: In-progress (Integer)<br />**Description**: Shows the in-progress value (integer) against the target. This value could contribute to a goal, but is not counted yet as actual.<br />|
|inprogressmoney|Edm.Decimal|**Display Name**: In-progress (Money)<br />**Description**: Shows the in-progress value (money) against the target. This value could contribute to a goal, but is not counted yet as actual.<br />|
|inprogressmoney_base|Edm.Decimal|**Display Name**: In-progress (Money) (Base)<br />**Description**: Shows the in-progress value (money) in base currency to track goal results against the target.<br />Read-only<br />|
|inprogressstring|Edm.String|**Display Name**: In-Progress<br />**Description**: In-progress value of the goal.<br />Read-only<br />|
|isamount|Edm.Boolean|**Display Name**: Metric Type<br />**Description**: Indicates whether the metric type is Count or Amount.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Amount</td></tr><tr><td>0</td><td>Count</td></tr><tbody></table>|
|isfiscalperiodgoal|Edm.Boolean|**Display Name**: Goal Period Type<br />**Description**: Select whether the goal period is a fiscal period or custom period.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Fiscal Period</td></tr><tr><td>0</td><td>Custom Period</td></tr><tbody></table>|
|isoverridden|Edm.Boolean|**Display Name**: Overridden<br />**Description**: Select whether the system rollup fields are updated. If set to Yes, the next system rollup will not update the values of the rollup fields with the system calculated values.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isoverride|Edm.Boolean|**Display Name**: Override<br />**Description**: Indicates whether the values of system rollup fields can be updated.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|lastrolledupdate|Edm.DateTimeOffset|**Display Name**: Last Rolled Up Date<br />**Description**: Shows the date and time when the goal was last rolled up. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|percentage|Edm.Decimal|**Display Name**: Percentage Achieved<br />**Description**: Shows the percentage achieved against the target goal.<br />|
|rolluperrorcode|Edm.Int32|**Display Name**: Rollup Error Code<br />**Description**: Error code associated with rollup.<br />|
|rolluponlyfromchildgoals|Edm.Boolean|**Display Name**: Roll Up Only from Child Goals<br />**Description**: Select whether the data should be rolled up only from the child goals.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows whether the goal is open, completed, or canceled. Completed and canceled goals are read-only and can't be edited.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the goal's status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Open</td></tr><tr><td>1</td><td>Closed</td></tr><tr><td>2</td><td>Discarded</td></tr><tbody></table>|
|stretchtargetdecimal|Edm.Decimal|**Display Name**: Stretch Target (Decimal)<br />**Description**: Select a stretch target (decimal) of the goal to define a higher or difficult level of goal than the usual ones.<br />|
|stretchtargetinteger|Edm.Int32|**Display Name**: Stretch Target (Integer)<br />**Description**: Select the stretch target (integer) of the goal to define a higher or difficult level of goal than the usual ones.<br />|
|stretchtargetmoney|Edm.Decimal|**Display Name**: Stretch Target (Money)<br />**Description**: Select stretch target (money) of the goal to define a higher or difficult level of goal than the usual ones.<br />|
|stretchtargetmoney_base|Edm.Decimal|**Display Name**: Stretch Target (Money) (Base)<br />**Description**: Shows the stretch target (money) in base currency to indicate a higher or difficult level of goal than the usual ones.<br />Read-only<br />|
|stretchtargetstring|Edm.String|**Display Name**: Stretched Target<br />**Description**: Stretch target value for all data types.<br />Read-only<br />|
|targetdecimal|Edm.Decimal|**Display Name**: Target (Decimal)<br />**Description**: Select a goal target of the decimal type to use for tracking data that include partial numbers, such as pounds sold of a product sold by weight.<br />|
|targetinteger|Edm.Int32|**Display Name**: Target (Integer)<br />**Description**: Select a goal target of the integer type to use for tracking anything countable in whole numbers, such as units sold.<br />|
|targetmoney|Edm.Decimal|**Display Name**: Target (Money)<br />**Description**: Select a goal target (money) to track a monetary amount such as revenue from a product.<br />|
|targetmoney_base|Edm.Decimal|**Display Name**: Target (Money) (Base)<br />**Description**: Shows the goal target of the money type in base currency.<br />Read-only<br />|
|targetstring|Edm.String|**Display Name**: Target<br />**Description**: Target value of the goal.<br />Read-only<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|title|Edm.String|**Display Name**: Name<br />**Description**: Type a title or name that describes the goal.<br />|
|treeid|Edm.Guid|**Display Name**: Tree ID<br />**Description**: Unique identifier of the goal tree.<br />Read-only<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version number of the goal.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_goalownerid_value|goalownerid_systemuser<br />goalownerid_team<br />|Choose the user or team responsible for meeting the goal.|
|_goalwitherrorid_value|goalwitherrorid<br />|Unique identifier of the goal that caused an error in the rollup of the goal hierarchy.|
|_metricid_value|metricid<br />|Choose the metric for the goal. This metric determines how the goal is tracked.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_ownerid_value|ownerid<br />|Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record.|
|_owningteam_value|owningteam<br />|Unique identifier of the team who owns the goal.|
|_owninguser_value|owninguser<br />|Unique identifier for the user who owns the record.|
|_parentgoalid_value|parentgoalid<br />|Choose a parent goal if the current goal is a child goal. This sets up a parent-child relationship for reporting and analytics.|
|_rollupqueryactualdecimalid_value|rollupqueryactualdecimalid<br />|Choose the query that will be used to calculate the actual data for the goal (decimal).|
|_rollupqueryactualintegerid_value|rollupqueryactualintegerid<br />|Choose the query that will be used to calculate the actual data for the goal (integer).|
|_rollupqueryactualmoneyid_value|rollupqueryactualmoneyid<br />|Choose the query that will be used to calculate the actual data for the goal (money).|
|_rollupquerycustomdecimalid_value|rollupquerycustomdecimalid<br />|Choose the query that will be used to calculate data for the custom rollup field (decimal).|
|_rollupquerycustomintegerid_value|rollupquerycustomintegerid<br />|Choose the query that will be used to calculate data for the custom rollup field (integer).|
|_rollupquerycustommoneyid_value|rollupquerycustommoneyid<br />|Choose the query that will be used to calculate data for the custom rollup field (money).|
|_rollupqueryinprogressdecimalid_value|rollupqueryinprogressdecimalid<br />|Choose the query that will be used to calculate data for the in-progress rollup field (decimal).|
|_rollupqueryinprogressintegerid_value|rollupqueryinprogressintegerid<br />|Choose the query that will be used to calculate data for the in-progress rollup field (integer).|
|_rollupqueryinprogressmoneyid_value|rollupqueryinprogressmoneyid<br />|Choose the query that will be used to calculate data for the in-progress rollup field (money).|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Choose the local currency for the record to make sure budgets are reported in the correct currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_goal_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_goal_createdonbehalfby|
|goalownerid_systemuser|[systemuser EntityType](systemuser.md)|user_goal_goalowner|
|goalownerid_team|[team EntityType](team.md)|team_goal_goalowner|
|goalwitherrorid|[goal EntityType](goal.md)|Goal_RollupError_Goal|
|metricid|[metric EntityType](metric.md)|metric_goal|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_goal_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_goal_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_goal|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_goal|
|owningteam|[team EntityType](team.md)|team_goal|
|owninguser|[systemuser EntityType](systemuser.md)|user_goal|
|parentgoalid|[goal EntityType](goal.md)|goal_parent_goal|
|rollupqueryactualdecimalid|[goalrollupquery EntityType](goalrollupquery.md)|goal_rollupquery_actualdecimal|
|rollupqueryactualintegerid|[goalrollupquery EntityType](goalrollupquery.md)|goalrollupquery_actualint|
|rollupqueryactualmoneyid|[goalrollupquery EntityType](goalrollupquery.md)|goal_rollupquery_actualmoney|
|rollupquerycustomdecimalid|[goalrollupquery EntityType](goalrollupquery.md)|goal_rollupquery_customdecimal|
|rollupquerycustomintegerid|[goalrollupquery EntityType](goalrollupquery.md)|goal_rollupquery_customint|
|rollupquerycustommoneyid|[goalrollupquery EntityType](goalrollupquery.md)|goal_rollupquery_custommoney|
|rollupqueryinprogressdecimalid|[goalrollupquery EntityType](goalrollupquery.md)|goal_rollupquery_inprogressdecimal|
|rollupqueryinprogressintegerid|[goalrollupquery EntityType](goalrollupquery.md)|goal_rollupquery_inprogressint|
|rollupqueryinprogressmoneyid|[goalrollupquery EntityType](goalrollupquery.md)|goal_rollupquery_inprogressmoney|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_Goal|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|Goal_Annotation|[annotation EntityType](annotation.md)|objectid_goal|  
|Goal_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_goal|  
|goal_connections1|[connection EntityType](connection.md)|record1id_goal|  
|goal_connections2|[connection EntityType](connection.md)|record2id_goal|  
|Goal_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_goal|  
|Goal_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_goal|  
|goal_parent_goal|[goal EntityType](goal.md)|parentgoalid|  
|Goal_RollupError_Goal|[goal EntityType](goal.md)|goalwitherrorid|  
|Goal_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_goal_syncerror|  

## Operations
The following operations can be used with the goal entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[Recalculate Action](../actions/recalculate.md)|Entity|[!INCLUDE[../actions/descriptions/recalculate.md](../actions/descriptions/recalculate.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|    

[!INCLUDE[./remarks/goal.md](./remarks/goal.md)]

### See also  
 [Use the Microsoft Dynamics CRM Web API](https://msdn.microsoft.com/library/mt593051.aspx)<br />
 [Web API EntityType Reference](../entitytypereference.md)<br />
 [Web API Action Reference](../actionreference.md)<br />
 [Web API Function Reference](../functionreference.md)<br />
 [Web API Query Function Reference](../queryfunctionreference.md)<br />
 [Web API EnumType Reference](../enumtypereference.md)<br />
 [Web API ComplexType Reference](../complextypereference.md)<br />
 [Web API Metadata EntityType Reference](../entitytypereference.md)<br />
 [Web API Solutions Reference](../solutionreference.md)<br />