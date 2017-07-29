---
title: "Microsoft Dynamics 365 Customer Engagement asyncoperation EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: a3d5e391-3751-4d67-bb96-2d03256c9ad1
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API asyncoperation entitytype."
---
# asyncoperation EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/asyncoperation.md](./descriptions/asyncoperation.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]asyncoperations </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>System Job</td></tr>
<tr><td><b>Primary Key:</b></td><td>asyncoperationid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The asyncoperation EntityType:
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|asyncoperationid|Edm.Guid|**Display Name**: System Job<br />**Description**: Unique identifier of the system job.<br />|
|completedon|Edm.DateTimeOffset|**Display Name**: Completed On<br />**Description**: Date and time when the system job was completed.<br />Read-only<br />|
|correlationid|Edm.Guid|**Display Name**: Correlation Id<br />**Description**: Unique identifier used to correlate between multiple SDK requests and system jobs.<br />|
|correlationupdatedtime|Edm.DateTimeOffset|**Display Name**: Correlation Updated Time<br />**Description**: Last time the correlation depth was updated.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the system job was created.<br />Read-only<br />|
|data|Edm.String|**Display Name**: Data<br />**Description**: Unstructured data associated with the system job.<br />|
|dependencytoken|Edm.String|**Display Name**: Dependency Token<br />**Description**: Execution of all operations with the same dependency token is serialized.<br />|
|depth|Edm.Int32|**Display Name**: Depth<br />**Description**: Number of SDK calls made since the first call.<br />|
|errorcode|Edm.Int32|**Display Name**: Error Code<br />**Description**: Error code returned from a canceled system job.<br />Read-only<br />|
|executiontimespan|Edm.Double|**Display Name**: ExecutionTimeSpan<br />**Description**: Time that the system job has taken to execute.<br />Read-only<br />|
|friendlymessage|Edm.String|**Display Name**: Friendly message<br />**Description**: Message provided by the system job.<br />|
|hostid|Edm.String|**Display Name**: Host<br />**Description**: Unique identifier of the host that owns this system job.<br />|
|iswaitingforevent|Edm.Boolean|**Display Name**: Waiting for Event<br />**Description**: Indicates that the system job is waiting for an event.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|message|Edm.String|**Display Name**: Message<br />**Description**: Message related to the system job.<br />Read-only<br />|
|messagename|Edm.String|**Display Name**: Message Name<br />**Description**: Name of the message that started this system job.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the system job was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: System Job Name<br />**Description**: Name of the system job.<br />|
|operationtype|Edm.Int32|**Display Name**: System Job Type<br />**Description**: Type of the system job.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>System Event</td></tr><tr><td>2</td><td>Bulk Email</td></tr><tr><td>3</td><td>Import File Parse</td></tr><tr><td>4</td><td>Transform Parse Data</td></tr><tr><td>5</td><td>Import</td></tr><tr><td>6</td><td>Activity Propagation</td></tr><tr><td>7</td><td>Duplicate Detection Rule Publish</td></tr><tr><td>8</td><td>Bulk Duplicate Detection</td></tr><tr><td>9</td><td>SQM Data Collection</td></tr><tr><td>10</td><td>Workflow</td></tr><tr><td>11</td><td>Quick Campaign</td></tr><tr><td>12</td><td>Matchcode Update</td></tr><tr><td>13</td><td>Bulk Delete</td></tr><tr><td>14</td><td>Deletion Service</td></tr><tr><td>15</td><td>Index Management</td></tr><tr><td>16</td><td>Collect Organization Statistics</td></tr><tr><td>17</td><td>Import Subprocess</td></tr><tr><td>18</td><td>Calculate Organization Storage Size</td></tr><tr><td>19</td><td>Collect Organization Database Statistics</td></tr><tr><td>20</td><td>Collection Organization Size Statistics</td></tr><tr><td>21</td><td>Database Tuning</td></tr><tr><td>22</td><td>Calculate Organization Maximum Storage Size</td></tr><tr><td>23</td><td>Bulk Delete Subprocess</td></tr><tr><td>24</td><td>Update Statistic Intervals</td></tr><tr><td>25</td><td>Organization Full Text Catalog Index</td></tr><tr><td>26</td><td>Database log backup</td></tr><tr><td>27</td><td>Update Contract States</td></tr><tr><td>28</td><td>DBCC SHRINKDATABASE maintenance job</td></tr><tr><td>29</td><td>DBCC SHRINKFILE maintenance job</td></tr><tr><td>30</td><td>Reindex all indices maintenance job</td></tr><tr><td>31</td><td>Storage Limit Notification</td></tr><tr><td>32</td><td>Cleanup inactive workflow assemblies</td></tr><tr><td>35</td><td>Recurring Series Expansion</td></tr><tr><td>38</td><td>Import Sample Data</td></tr><tr><td>40</td><td>Goal Roll Up</td></tr><tr><td>41</td><td>Audit Partition Creation</td></tr><tr><td>42</td><td>Check For Language Pack Updates</td></tr><tr><td>43</td><td>Provision Language Pack</td></tr><tr><td>44</td><td>Update Organization Database</td></tr><tr><td>45</td><td>Update Solution</td></tr><tr><td>46</td><td>Regenerate Entity Row Count Snapshot Data</td></tr><tr><td>47</td><td>Regenerate Read Share Snapshot Data</td></tr><tr><td>50</td><td>Outgoing Activity</td></tr><tr><td>51</td><td>Incoming Email Processing</td></tr><tr><td>52</td><td>Mailbox Test Access</td></tr><tr><td>53</td><td>Encryption Health Check</td></tr><tr><td>54</td><td>Execute Async Request</td></tr><tr><td>49</td><td>Post to Yammer</td></tr><tr><td>56</td><td>Update Entitlement States</td></tr><tr><td>57</td><td>Calculate Rollup Field</td></tr><tr><td>58</td><td>Mass Calculate Rollup Field</td></tr><tr><td>59</td><td>Import Translation</td></tr><tr><td>62</td><td>Convert Date And Time Behavior</td></tr><tr><td>63</td><td>EntityKey Index Creation</td></tr><tr><td>65</td><td>Update Knowledge Article States</td></tr><tr><td>68</td><td>Resource Booking Sync</td></tr><tr><td>69</td><td>Relationship Assistant Cards</td></tr><tr><td>71</td><td>Cleanup Solution Components</td></tr><tr><td>72</td><td>App Module Metadata Operation</td></tr><tbody></table>|
|parentpluginexecutionid|Edm.Guid||
|postponeuntil|Edm.DateTimeOffset|**Display Name**: Postpone Until<br />**Description**: Indicates whether the system job should run only after the specified date and time.<br />|
|primaryentitytype|Edm.String|**Display Name**: Primary Entity Type<br />**Description**: Type of entity with which the system job is primarily associated.<br />|
|recurrencepattern|Edm.String|**Display Name**: Recurrence Pattern<br />**Description**: Pattern of the system job's recurrence.<br />|
|recurrencestarttime|Edm.DateTimeOffset|**Display Name**: Recurrence Start<br />**Description**: Starting time in UTC for the recurrence pattern.<br />|
|requestid|Edm.Guid|**Display Name**: Request<br />**Description**: Unique identifier of the request that generated the system job.<br />|
|retrycount|Edm.Int32|**Display Name**: Retry Count<br />**Description**: Number of times to retry the system job.<br />Read-only<br />|
|sequence|Edm.Int64|**Display Name**: Sequence<br />**Description**: Order in which operations were submitted.<br />Read-only<br />|
|startedon|Edm.DateTimeOffset|**Display Name**: Started On<br />**Description**: Date and time when the system job was started.<br />Read-only<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the system job.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Ready</td></tr><tr><td>1</td><td>Suspended</td></tr><tr><td>2</td><td>Locked</td></tr><tr><td>3</td><td>Completed</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the system job.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Waiting For Resources</td></tr><tr><td>10</td><td>Waiting</td></tr><tr><td>20</td><td>In Progress</td></tr><tr><td>21</td><td>Pausing</td></tr><tr><td>22</td><td>Canceling</td></tr><tr><td>30</td><td>Succeeded</td></tr><tr><td>31</td><td>Failed</td></tr><tr><td>32</td><td>Canceled</td></tr><tbody></table>|
|subtype|Edm.Int32|**Display Name**: Subtype<br />**Description**: The Subtype of the Async Job<br />Read-only<br />|
|timezoneruleversionnumber|Edm.Int32|**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Description**: Time zone code that was in use when the record was created.<br />|
|workflowstagename|Edm.String|**Display Name**: Workflow Stage<br />**Description**: Name of a workflow stage.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the system job.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the asyncoperation.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the system job.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the asyncoperation.|
|_ownerid_value|ownerid<br />|Unique identifier of the user or team who owns the system job.|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier of the business unit that owns the system job.|
|_owningextensionid_value|owningextensionid<br />|Unique identifier of the owning extension with which the system job is associated.|
|_owningteam_value|owningteam<br />|Unique identifier of the team who owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier of the user who owns the record.|
|_regardingobjectid_value|regardingobjectid_territory<br />regardingobjectid_leadaddress<br />regardingobjectid_leadcompetitors<br />regardingobjectid_lead<br />regardingobjectid_dynamicproperty<br />regardingobjectid_dynamicpropertyassociation<br />regardingobjectid_dynamicpropertyinstance<br />regardingobjectid_dynamicpropertyoptionsetitem<br />regardingobjectid_pricelevel<br />regardingobjectid_product<br />regardingobjectid_productassociation<br />regardingobjectid_productpricelevel<br />regardingobjectid_productsubstitute<br />regardingobjectid_uom<br />regardingobjectid_uomschedule<br />regardingobjectid_bookableresource<br />regardingobjectid_bookableresourcebooking<br />regardingobjectid_bookableresourcebookingheader<br />regardingobjectid_bookableresourcecategory<br />regardingobjectid_bookableresourcecategoryassn<br />regardingobjectid_bookableresourcecharacteristic<br />regardingobjectid_bookableresourcegroup<br />regardingobjectid_bookingstatus<br />regardingobjectid_characteristic<br />regardingobjectid_ratingmodel<br />regardingobjectid_ratingvalue<br />regardingobjectid_bulkoperationlog<br />regardingobjectid_campaign<br />regardingobjectid_campaignactivityitem<br />regardingobjectid_campaignitem<br />regardingobjectid_list<br />regardingobjectid_listmember<br />regardingobjectid_constraintbasedgroup<br />regardingobjectid_contract<br />regardingobjectid_contractdetail<br />regardingobjectid_contracttemplate<br />regardingobjectid_entitlement<br />regardingobjectid_entitlementchannel<br />regardingobjectid_entitlementtemplate<br />regardingobjectid_entitlementtemplatechannel<br />regardingobjectid_equipment<br />regardingobjectid_incident<br />regardingobjectid_knowledgearticleincident<br />regardingobjectid_phonetocaseprocess<br />regardingobjectid_resource<br />regardingobjectid_resourcegroup<br />regardingobjectid_resourcespec<br />regardingobjectid_service<br />regardingobjectid_site<br />regardingobjectid_competitoraddress<br />regardingobjectid_competitorproduct<br />regardingobjectid_competitorsalesliterature<br />regardingobjectid_contactinvoices<br />regardingobjectid_contactorders<br />regardingobjectid_contactquotes<br />regardingobjectid_discount<br />regardingobjectid_discounttype<br />regardingobjectid_invoice<br />regardingobjectid_invoicedetail<br />regardingobjectid_leadproduct<br />regardingobjectid_leadtoopportunitysalesprocess<br />regardingobjectid_opportunity<br />regardingobjectid_opportunitycompetitors<br />regardingobjectid_opportunityproduct<br />regardingobjectid_opportunitysalesprocess<br />regardingobjectid_productsalesliterature<br />regardingobjectid_quote<br />regardingobjectid_quotedetail<br />regardingobjectid_salesliterature<br />regardingobjectid_salesliteratureitem<br />regardingobjectid_salesorder<br />regardingobjectid_salesorderdetail<br />regardingobjectid_competitor<br />regardingobjectid_adx_contentsnippet<br />regardingobjectid_adx_pagetemplate<br />regardingobjectid_adx_sitemarker<br />regardingobjectid_adx_sitesetting<br />regardingobjectid_adx_webfile<br />regardingobjectid_adx_weblink<br />regardingobjectid_adx_weblinkset<br />regardingobjectid_adx_webnotificationurl<br />regardingobjectid_adx_webpage<br />regardingobjectid_adx_webrole<br />regardingobjectid_adx_website<br />regardingobjectid_adx_ad<br />regardingobjectid_adx_adplacement<br />regardingobjectid_adx_entitypermission<br />regardingobjectid_adx_invitation<br />regardingobjectid_adx_pagealert<br />regardingobjectid_adx_pagenotification<br />regardingobjectid_adx_pagetag<br />regardingobjectid_adx_poll<br />regardingobjectid_adx_polloption<br />regardingobjectid_adx_pollplacement<br />regardingobjectid_adx_pollsubmission<br />regardingobjectid_adx_portallanguage<br />regardingobjectid_adx_publishingstate<br />regardingobjectid_adx_publishingstatetransitionrule<br />regardingobjectid_adx_redirect<br />regardingobjectid_adx_setting<br />regardingobjectid_adx_shortcut<br />regardingobjectid_adx_tag<br />regardingobjectid_adx_urlhistory<br />regardingobjectid_adx_webfilelog<br />regardingobjectid_adx_webpageaccesscontrolrule<br />regardingobjectid_adx_webpagehistory<br />regardingobjectid_adx_webpagelog<br />regardingobjectid_adx_websiteaccess<br />regardingobjectid_adx_websitebinding<br />regardingobjectid_adx_websitelanguage<br />regardingobjectid_adx_webtemplate<br />regardingobjectid_adx_webnotificationentity<br />regardingobjectid_adx_externalidentity<br />regardingobjectid_adx_entityform<br />regardingobjectid_adx_entityformmetadata<br />regardingobjectid_adx_entitylist<br />regardingobjectid_adx_webform<br />regardingobjectid_adx_webformmetadata<br />regardingobjectid_adx_webformsession<br />regardingobjectid_adx_webformstep<br />regardingobjectid_msdyn_actual<br />regardingobjectid_msdyn_bookingalertstatus<br />regardingobjectid_msdyn_bookingchange<br />regardingobjectid_msdyn_bookingrule<br />regardingobjectid_msdyn_bookingsetupmetadata<br />regardingobjectid_msdyn_organizationalunit<br />regardingobjectid_msdyn_priority<br />regardingobjectid_msdyn_requirementcharacteristic<br />regardingobjectid_msdyn_requirementorganizationunit<br />regardingobjectid_msdyn_requirementresourcecategory<br />regardingobjectid_msdyn_requirementresourcepreference<br />regardingobjectid_msdyn_requirementstatus<br />regardingobjectid_msdyn_resourcerequirement<br />regardingobjectid_msdyn_resourcerequirementdetail<br />regardingobjectid_msdyn_resourceterritory<br />regardingobjectid_msdyn_scheduleboardsetting<br />regardingobjectid_msdyn_schedulingparameter<br />regardingobjectid_msdyn_systemuserschedulersetting<br />regardingobjectid_msdyn_timegroup<br />regardingobjectid_msdyn_timegroupdetail<br />regardingobjectid_msdyn_transactionorigin<br />regardingobjectid_msdyn_workhourtemplate<br />regardingobjectid_msdyn_agreement<br />regardingobjectid_msdyn_agreementbookingdate<br />regardingobjectid_msdyn_agreementbookingincident<br />regardingobjectid_msdyn_agreementbookingproduct<br />regardingobjectid_msdyn_agreementbookingservice<br />regardingobjectid_msdyn_agreementbookingservicetask<br />regardingobjectid_msdyn_agreementbookingsetup<br />regardingobjectid_msdyn_agreementinvoicedate<br />regardingobjectid_msdyn_agreementinvoiceproduct<br />regardingobjectid_msdyn_agreementinvoicesetup<br />regardingobjectid_msdyn_agreementsubstatus<br />regardingobjectid_msdyn_bookingjournal<br />regardingobjectid_msdyn_bookingtimestamp<br />regardingobjectid_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799<br />regardingobjectid_msdyn_bpf_989e9b1857e24af18787d5143b67523b<br />regardingobjectid_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3<br />regardingobjectid_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39<br />regardingobjectid_msdyn_customerasset<br />regardingobjectid_msdyn_fieldservicepricelistitem<br />regardingobjectid_msdyn_fieldservicesetting<br />regardingobjectid_msdyn_fieldservicesystemjob<br />regardingobjectid_msdyn_incidenttype<br />regardingobjectid_msdyn_incidenttypecharacteristic<br />regardingobjectid_msdyn_incidenttypeproduct<br />regardingobjectid_msdyn_incidenttypeservice<br />regardingobjectid_msdyn_incidenttypeservicetask<br />regardingobjectid_msdyn_inventoryadjustment<br />regardingobjectid_msdyn_inventoryadjustmentproduct<br />regardingobjectid_msdyn_inventoryjournal<br />regardingobjectid_msdyn_inventorytransfer<br />regardingobjectid_msdyn_orderinvoicingdate<br />regardingobjectid_msdyn_orderinvoicingproduct<br />regardingobjectid_msdyn_orderinvoicingsetup<br />regardingobjectid_msdyn_orderinvoicingsetupdate<br />regardingobjectid_msdyn_payment<br />regardingobjectid_msdyn_paymentdetail<br />regardingobjectid_msdyn_paymentmethod<br />regardingobjectid_msdyn_paymentterm<br />regardingobjectid_msdyn_postalcode<br />regardingobjectid_msdyn_productinventory<br />regardingobjectid_msdyn_purchaseorder<br />regardingobjectid_msdyn_purchaseorderbill<br />regardingobjectid_msdyn_purchaseorderproduct<br />regardingobjectid_msdyn_purchaseorderreceipt<br />regardingobjectid_msdyn_purchaseorderreceiptproduct<br />regardingobjectid_msdyn_purchaseordersubstatus<br />regardingobjectid_msdyn_quotebookingincident<br />regardingobjectid_msdyn_quotebookingproduct<br />regardingobjectid_msdyn_quotebookingservice<br />regardingobjectid_msdyn_quotebookingservicetask<br />regardingobjectid_msdyn_quotebookingsetup<br />regardingobjectid_msdyn_quoteinvoicingproduct<br />regardingobjectid_msdyn_quoteinvoicingsetup<br />regardingobjectid_msdyn_resourcepaytype<br />regardingobjectid_msdyn_rma<br />regardingobjectid_msdyn_rmaproduct<br />regardingobjectid_msdyn_rmareceipt<br />regardingobjectid_msdyn_rmareceiptproduct<br />regardingobjectid_msdyn_rmasubstatus<br />regardingobjectid_msdyn_rtv<br />regardingobjectid_msdyn_rtvproduct<br />regardingobjectid_msdyn_rtvsubstatus<br />regardingobjectid_msdyn_servicetasktype<br />regardingobjectid_msdyn_shipvia<br />regardingobjectid_msdyn_taxcode<br />regardingobjectid_msdyn_taxcodedetail<br />regardingobjectid_msdyn_timeoffrequest<br />regardingobjectid_msdyn_uniquenumber<br />regardingobjectid_msdyn_warehouse<br />regardingobjectid_msdyn_workorder<br />regardingobjectid_msdyn_workordercharacteristic<br />regardingobjectid_msdyn_workorderdetailsgenerationqueue<br />regardingobjectid_msdyn_workorderincident<br />regardingobjectid_msdyn_workorderproduct<br />regardingobjectid_msdyn_workorderresourcerestriction<br />regardingobjectid_msdyn_workorderservice<br />regardingobjectid_msdyn_workorderservicetask<br />regardingobjectid_msdyn_workordersubstatus<br />regardingobjectid_msdyn_workordertype<br />regardingobjectid_msdyn_glympseagent<br />regardingobjectid_msdyn_glympsesetting<br />regardingobjectid_msdyn_glympsetask<br />regardingobjectid_msdyn_iotalert<br />regardingobjectid_msdyn_iotdevice<br />regardingobjectid_msdyn_iotdevicecategory<br />regardingobjectid_msdyn_iotdevicecommand<br />regardingobjectid_msdyn_iotdeviceregistrationhistory<br />regardingobjectid_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b<br />regardingobjectid_msdyn_accountpricelist<br />regardingobjectid_msdyn_batchjob<br />regardingobjectid_msdyn_characteristicreqforteammember<br />regardingobjectid_msdyn_contactpricelist<br />regardingobjectid_msdyn_contractlineinvoiceschedule<br />regardingobjectid_msdyn_contractlinescheduleofvalue<br />regardingobjectid_msdyn_dataexport<br />regardingobjectid_msdyn_delegation<br />regardingobjectid_msdyn_estimate<br />regardingobjectid_msdyn_estimateline<br />regardingobjectid_msdyn_expense<br />regardingobjectid_msdyn_expensecategory<br />regardingobjectid_msdyn_expensereceipt<br />regardingobjectid_msdyn_fact<br />regardingobjectid_msdyn_fieldcomputation<br />regardingobjectid_msdyn_findworkevent<br />regardingobjectid_msdyn_integrationjob<br />regardingobjectid_msdyn_integrationjobdetail<br />regardingobjectid_msdyn_invoicefrequency<br />regardingobjectid_msdyn_invoicefrequencydetail<br />regardingobjectid_msdyn_invoicelinetransaction<br />regardingobjectid_msdyn_journal<br />regardingobjectid_msdyn_journalline<br />regardingobjectid_msdyn_mlresultcache<br />regardingobjectid_msdyn_opportunitylineresourcecategory<br />regardingobjectid_msdyn_opportunitylinetransaction<br />regardingobjectid_msdyn_opportunitylinetransactioncategory<br />regardingobjectid_msdyn_opportunitylinetransactionclassificatio<br />regardingobjectid_msdyn_opportunitypricelist<br />regardingobjectid_msdyn_orderlineresourcecategory<br />regardingobjectid_msdyn_orderlinetransaction<br />regardingobjectid_msdyn_orderlinetransactioncategory<br />regardingobjectid_msdyn_orderlinetransactionclassification<br />regardingobjectid_msdyn_orderpricelist<br />regardingobjectid_msdyn_processnotes<br />regardingobjectid_msdyn_project<br />regardingobjectid_msdyn_projectapproval<br />regardingobjectid_msdyn_projectparameter<br />regardingobjectid_msdyn_projectparameterpricelist<br />regardingobjectid_msdyn_projectpricelist<br />regardingobjectid_msdyn_projecttask<br />regardingobjectid_msdyn_projecttaskdependency<br />regardingobjectid_msdyn_projecttaskstatususer<br />regardingobjectid_msdyn_projectteam<br />regardingobjectid_msdyn_projectteammembersignup<br />regardingobjectid_msdyn_projecttransactioncategory<br />regardingobjectid_msdyn_quotelineanalyticsbreakdown<br />regardingobjectid_msdyn_quotelineinvoiceschedule<br />regardingobjectid_msdyn_quotelineresourcecategory<br />regardingobjectid_msdyn_quotelinescheduleofvalue<br />regardingobjectid_msdyn_quotelinetransaction<br />regardingobjectid_msdyn_quotelinetransactioncategory<br />regardingobjectid_msdyn_quotelinetransactionclassification<br />regardingobjectid_msdyn_quotepricelist<br />regardingobjectid_msdyn_resourceassignment<br />regardingobjectid_msdyn_resourceassignmentdetail<br />regardingobjectid_msdyn_resourcecategorypricelevel<br />regardingobjectid_msdyn_resourcerequest<br />regardingobjectid_msdyn_rolecompetencyrequirement<br />regardingobjectid_msdyn_roleutilization<br />regardingobjectid_msdyn_timeentry<br />regardingobjectid_msdyn_timeoffcalendar<br />regardingobjectid_msdyn_transactioncategory<br />regardingobjectid_msdyn_transactioncategoryclassification<br />regardingobjectid_msdyn_transactioncategoryhierarchyelement<br />regardingobjectid_msdyn_transactioncategorypricelevel<br />regardingobjectid_msdyn_transactionconnection<br />regardingobjectid_msdyn_transactiontype<br />regardingobjectid_msdyn_userworkhistory<br />regardingobjectid_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d<br />regardingobjectid_msdyn_bpf_665e73aa18c247d886bfc50499c73b82<br />regardingobjectid_msdyn_collaboration<br />regardingobjectid_msdyn_groupsheader<br />regardingobjectid_msdyn_pendinggroupmembers<br />regardingobjectid_msdyn_optimizationrequestbooking<br />regardingobjectid_msdyn_routingengineconfiguration<br />regardingobjectid_msdyn_routingjobconfiguration<br />regardingobjectid_msdyn_routingoptimizationrequest<br />regardingobjectid_msdyn_routingprofileconfiguration<br />regardingobjectid_msdyn_schedulingoptimizationhealthlog<br />regardingobjectid_msdyncrm_appointmentactivitymarketingtemplate<br />regardingobjectid_msdyncrm_campaigncustomchannelactivity<br />regardingobjectid_msdyncrm_contentsettings<br />regardingobjectid_msdyncrm_customerinsightsinfo<br />regardingobjectid_msdyncrm_customerjourney<br />regardingobjectid_msdyncrm_customerjourneyiteration<br />regardingobjectid_msdyncrm_customerjourneytemplate<br />regardingobjectid_msdyncrm_customerjourneyworkflowlink<br />regardingobjectid_msdyncrm_file<br />regardingobjectid_msdyncrm_formpage<br />regardingobjectid_msdyncrm_formpagetemplate<br />regardingobjectid_msdyncrm_geopin<br />regardingobjectid_msdyncrm_keyword<br />regardingobjectid_msdyncrm_marketingconfiguration<br />regardingobjectid_msdyncrm_marketingdynamiccontentmetadata<br />regardingobjectid_msdyncrm_marketingemail<br />regardingobjectid_msdyncrm_marketingemaildynamiccontentmetadata<br />regardingobjectid_msdyncrm_marketingemailtemplate<br />regardingobjectid_msdyncrm_marketingemailtestsend<br />regardingobjectid_msdyncrm_marketingform<br />regardingobjectid_msdyncrm_marketingformfield<br />regardingobjectid_msdyncrm_marketingformtemplate<br />regardingobjectid_msdyncrm_marketingpage<br />regardingobjectid_msdyncrm_marketingpageconfiguration<br />regardingobjectid_msdyncrm_marketingpagetemplate<br />regardingobjectid_msdyncrm_matchingstrategy<br />regardingobjectid_msdyncrm_mktactivity<br />regardingobjectid_msdyncrm_phonecallactivitymarketingtemplate<br />regardingobjectid_msdyncrm_portalsettings<br />regardingobjectid_msdyncrm_redirecturl<br />regardingobjectid_msdyncrm_segment<br />regardingobjectid_msdyncrm_taskactivitymarketingtemplate<br />regardingobjectid_msdyncrm_uicconfig<br />regardingobjectid_msdyncrm_usergeoregion<br />regardingobjectid_msdyncrm_website<br />regardingobjectid_msdyncrm_leadscore<br />regardingobjectid_msdyncrm_leadscoremodel<br />regardingobjectid_msdyncrm_leadtoopportunity<br />regardingobjectid_msdyn_answer<br />regardingobjectid_msdyn_azuredeployment<br />regardingobjectid_msdyn_feedbackmapping<br />regardingobjectid_msdyn_feedbacksubsurvey<br />regardingobjectid_msdyn_image<br />regardingobjectid_msdyn_imagetokencache<br />regardingobjectid_msdyn_import<br />regardingobjectid_msdyn_linkedanswer<br />regardingobjectid_msdyn_page<br />regardingobjectid_msdyn_question<br />regardingobjectid_msdyn_questiongroup<br />regardingobjectid_msdyn_questionresponse<br />regardingobjectid_msdyn_questiontype<br />regardingobjectid_msdyn_responseaction<br />regardingobjectid_msdyn_responseblobstore<br />regardingobjectid_msdyn_responsecondition<br />regardingobjectid_msdyn_responseoutcome<br />regardingobjectid_msdyn_responserouting<br />regardingobjectid_msdyn_section<br />regardingobjectid_msdyn_survey<br />regardingobjectid_msdyn_surveylog<br />regardingobjectid_msdyn_surveyresponse<br />regardingobjectid_msdyn_theme<br />regardingobjectid_msdyn_vocconfiguration<br />regardingobjectid_msevtmgt_attendeepass<br />regardingobjectid_msevtmgt_authenticationsettings<br />regardingobjectid_msevtmgt_building<br />regardingobjectid_msevtmgt_checkin<br />regardingobjectid_msevtmgt_entitycounter<br />regardingobjectid_msevtmgt_event<br />regardingobjectid_msevtmgt_eventadministration<br />regardingobjectid_msevtmgt_eventmanagementconfiguration<br />regardingobjectid_msevtmgt_eventpurchase<br />regardingobjectid_msevtmgt_eventpurchaseattendee<br />regardingobjectid_msevtmgt_eventpurchasepass<br />regardingobjectid_msevtmgt_eventregistration<br />regardingobjectid_msevtmgt_eventteammember<br />regardingobjectid_msevtmgt_eventvendor<br />regardingobjectid_msevtmgt_hotel<br />regardingobjectid_msevtmgt_hotelroomallocation<br />regardingobjectid_msevtmgt_hotelroomreservation<br />regardingobjectid_msevtmgt_layout<br />regardingobjectid_msevtmgt_pass<br />regardingobjectid_msevtmgt_room<br />regardingobjectid_msevtmgt_session<br />regardingobjectid_msevtmgt_sessionregistration<br />regardingobjectid_msevtmgt_sessiontrack<br />regardingobjectid_msevtmgt_speaker<br />regardingobjectid_msevtmgt_speakerengagement<br />regardingobjectid_msevtmgt_sponsorablearticle<br />regardingobjectid_msevtmgt_sponsorship<br />regardingobjectid_msevtmgt_venue<br />regardingobjectid_msevtmgt_webinarconfiguration<br />regardingobjectid_msevtmgt_webinarconsent<br />regardingobjectid_msevtmgt_webinarprovider<br />regardingobjectid_msevtmgt_webinartype<br />regardingobjectid_msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99<br />regardingobjectid_msdyncrm_linkedinaccount<br />regardingobjectid_msdyncrm_linkedinactivity<br />regardingobjectid_msdyncrm_linkedincampaign<br />regardingobjectid_msdyncrm_linkedinconfiguration<br />regardingobjectid_msdyncrm_linkedinfieldmapping<br />regardingobjectid_msdyncrm_linkedinform<br />regardingobjectid_msdyncrm_linkedinformanswer<br />regardingobjectid_msdyncrm_linkedinformquestion<br />regardingobjectid_msdyncrm_linkedinformsubmission<br />regardingobjectid_msdyncrm_linkedinleadmatchingstrategy<br />regardingobjectid_msdyncrm_linkedinuserprofile<br />regardingobjectid_theme<br />regardingobjectid_new_interactionforemail<br />regardingobjectid_knowledgearticle<br />regardingobjectid_post<br />regardingobjectid_position<br />regardingobjectid_similarityrule<br />regardingobjectid_knowledgebaserecord<br />regardingobjectid_report<br />regardingobjectid_privilege<br />regardingobjectid_goalrollupquery<br />regardingobjectid_postfollow<br />regardingobjectid_businessunit<br />regardingobjectid_annualfiscalcalendar<br />regardingobjectid_monthlyfiscalcalendar<br />regardingobjectid_mailbox<br />regardingobjectid_importfile<br />regardingobjectid_importdata<br />regardingobjectid_team<br />regardingobjectid_kbarticletemplate<br />regardingobjectid_emailserverprofile<br />regardingobjectid_userform<br />regardingobjectid_transactioncurrency<br />regardingobjectid_socialprofile<br />regardingobjectid_importmap<br />regardingobjectid_account<br />regardingobjectid_queueitem<br />regardingobjectid_quarterlyfiscalcalendar<br />regardingobjectid_queue<br />regardingobjectid_template<br />regardingobjectid_kbarticle<br />regardingobjectid_systemform<br />regardingobjectid_organization<br />regardingobjectid_connectionrole<br />regardingobjectid_kbarticlecomment<br />regardingobjectid_systemuser<br />regardingobjectid_mailmergetemplate<br />regardingobjectid_calendar<br />regardingobjectid_connection<br />regardingobjectid_metric<br />regardingobjectid_role<br />regardingobjectid_subject<br />regardingobjectid_savedquery<br />regardingobjectid_sla<br />regardingobjectid_activitymimeattachment<br />regardingobjectid_annotation<br />regardingobjectid_userquery<br />regardingobjectid_contact<br />regardingobjectid_sharepointsite<br />regardingobjectid_businessunitnewsarticle<br />regardingobjectid_goal<br />regardingobjectid_importlog<br />regardingobjectid_semiannualfiscalcalendar<br />regardingobjectid_fixedmonthlyfiscalcalendar<br />regardingobjectid_customeraddress<br />regardingobjectid_sharepointdocumentlocation<br />regardingobjectid_activitypointer<br />regardingobjectid_import<br />||
|_workflowactivationid_value|workflowactivationid<br />|Unique identifier of the workflow activation related to the system job.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_asyncoperation_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_asyncoperation_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_asyncoperation_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_asyncoperation_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_asyncoperations|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_asyncoperation|
|owningextensionid|[sdkmessageprocessingstep EntityType](sdkmessageprocessingstep.md)|SdkMessageProcessingStep_AsyncOperations|
|owningteam|[team EntityType](team.md)|team_asyncoperation|
|owninguser|[systemuser EntityType](systemuser.md)|system_user_asyncoperation|
|regardingobjectid_account|[account EntityType](account.md)|Account_AsyncOperations|
|regardingobjectid_activitymimeattachment|[activitymimeattachment EntityType](activitymimeattachment.md)|ActivityMimeAttachment_AsyncOperations|
|regardingobjectid_activitypointer|[activitypointer EntityType](activitypointer.md)|ActivityPointer_AsyncOperations|
|regardingobjectid_adx_ad|[adx_ad EntityType](adx_ad.md)|adx_ad_AsyncOperations|
|regardingobjectid_adx_adplacement|[adx_adplacement EntityType](adx_adplacement.md)|adx_adplacement_AsyncOperations|
|regardingobjectid_adx_alertsubscription|[adx_alertsubscription EntityType](adx_alertsubscription.md)|adx_alertsubscription_AsyncOperations|
|regardingobjectid_adx_contentsnippet|[adx_contentsnippet EntityType](adx_contentsnippet.md)|adx_contentsnippet_AsyncOperations|
|regardingobjectid_adx_entityform|[adx_entityform EntityType](adx_entityform.md)|adx_entityform_AsyncOperations|
|regardingobjectid_adx_entityformmetadata|[adx_entityformmetadata EntityType](adx_entityformmetadata.md)|adx_entityformmetadata_AsyncOperations|
|regardingobjectid_adx_entitylist|[adx_entitylist EntityType](adx_entitylist.md)|adx_entitylist_AsyncOperations|
|regardingobjectid_adx_entitypermission|[adx_entitypermission EntityType](adx_entitypermission.md)|adx_entitypermission_AsyncOperations|
|regardingobjectid_adx_externalidentity|[adx_externalidentity EntityType](adx_externalidentity.md)|adx_externalidentity_AsyncOperations|
|regardingobjectid_adx_invitation|[adx_invitation EntityType](adx_invitation.md)|adx_invitation_AsyncOperations|
|regardingobjectid_adx_inviteredemption|[adx_inviteredemption EntityType](adx_inviteredemption.md)|adx_inviteredemption_AsyncOperations|
|regardingobjectid_adx_pagealert|[adx_pagealert EntityType](adx_pagealert.md)|adx_pagealert_AsyncOperations|
|regardingobjectid_adx_pagenotification|[adx_pagenotification EntityType](adx_pagenotification.md)|adx_pagenotification_AsyncOperations|
|regardingobjectid_adx_pagetag|[adx_pagetag EntityType](adx_pagetag.md)|adx_pagetag_AsyncOperations|
|regardingobjectid_adx_pagetemplate|[adx_pagetemplate EntityType](adx_pagetemplate.md)|adx_pagetemplate_AsyncOperations|
|regardingobjectid_adx_poll|[adx_poll EntityType](adx_poll.md)|adx_poll_AsyncOperations|
|regardingobjectid_adx_polloption|[adx_polloption EntityType](adx_polloption.md)|adx_polloption_AsyncOperations|
|regardingobjectid_adx_pollplacement|[adx_pollplacement EntityType](adx_pollplacement.md)|adx_pollplacement_AsyncOperations|
|regardingobjectid_adx_pollsubmission|[adx_pollsubmission EntityType](adx_pollsubmission.md)|adx_pollsubmission_AsyncOperations|
|regardingobjectid_adx_portalcomment|[adx_portalcomment EntityType](adx_portalcomment.md)|adx_portalcomment_AsyncOperations|
|regardingobjectid_adx_portallanguage|[adx_portallanguage EntityType](adx_portallanguage.md)|adx_portallanguage_AsyncOperations|
|regardingobjectid_adx_publishingstate|[adx_publishingstate EntityType](adx_publishingstate.md)|adx_publishingstate_AsyncOperations|
|regardingobjectid_adx_publishingstatetransitionrule|[adx_publishingstatetransitionrule EntityType](adx_publishingstatetransitionrule.md)|adx_publishingstatetransitionrule_AsyncOperations|
|regardingobjectid_adx_redirect|[adx_redirect EntityType](adx_redirect.md)|adx_redirect_AsyncOperations|
|regardingobjectid_adx_setting|[adx_setting EntityType](adx_setting.md)|adx_setting_AsyncOperations|
|regardingobjectid_adx_shortcut|[adx_shortcut EntityType](adx_shortcut.md)|adx_shortcut_AsyncOperations|
|regardingobjectid_adx_sitemarker|[adx_sitemarker EntityType](adx_sitemarker.md)|adx_sitemarker_AsyncOperations|
|regardingobjectid_adx_sitesetting|[adx_sitesetting EntityType](adx_sitesetting.md)|adx_sitesetting_AsyncOperations|
|regardingobjectid_adx_tag|[adx_tag EntityType](adx_tag.md)|adx_tag_AsyncOperations|
|regardingobjectid_adx_urlhistory|[adx_urlhistory EntityType](adx_urlhistory.md)|adx_urlhistory_AsyncOperations|
|regardingobjectid_adx_webfile|[adx_webfile EntityType](adx_webfile.md)|adx_webfile_AsyncOperations|
|regardingobjectid_adx_webfilelog|[adx_webfilelog EntityType](adx_webfilelog.md)|adx_webfilelog_AsyncOperations|
|regardingobjectid_adx_webform|[adx_webform EntityType](adx_webform.md)|adx_webform_AsyncOperations|
|regardingobjectid_adx_webformmetadata|[adx_webformmetadata EntityType](adx_webformmetadata.md)|adx_webformmetadata_AsyncOperations|
|regardingobjectid_adx_webformsession|[adx_webformsession EntityType](adx_webformsession.md)|adx_webformsession_AsyncOperations|
|regardingobjectid_adx_webformstep|[adx_webformstep EntityType](adx_webformstep.md)|adx_webformstep_AsyncOperations|
|regardingobjectid_adx_weblink|[adx_weblink EntityType](adx_weblink.md)|adx_weblink_AsyncOperations|
|regardingobjectid_adx_weblinkset|[adx_weblinkset EntityType](adx_weblinkset.md)|adx_weblinkset_AsyncOperations|
|regardingobjectid_adx_webnotificationentity|[adx_webnotificationentity EntityType](adx_webnotificationentity.md)|adx_webnotificationentity_AsyncOperations|
|regardingobjectid_adx_webnotificationurl|[adx_webnotificationurl EntityType](adx_webnotificationurl.md)|adx_webnotificationurl_AsyncOperations|
|regardingobjectid_adx_webpage|[adx_webpage EntityType](adx_webpage.md)|adx_webpage_AsyncOperations|
|regardingobjectid_adx_webpageaccesscontrolrule|[adx_webpageaccesscontrolrule EntityType](adx_webpageaccesscontrolrule.md)|adx_webpageaccesscontrolrule_AsyncOperations|
|regardingobjectid_adx_webpagehistory|[adx_webpagehistory EntityType](adx_webpagehistory.md)|adx_webpagehistory_AsyncOperations|
|regardingobjectid_adx_webpagelog|[adx_webpagelog EntityType](adx_webpagelog.md)|adx_webpagelog_AsyncOperations|
|regardingobjectid_adx_webrole|[adx_webrole EntityType](adx_webrole.md)|adx_webrole_AsyncOperations|
|regardingobjectid_adx_website|[adx_website EntityType](adx_website.md)|adx_website_AsyncOperations|
|regardingobjectid_adx_websiteaccess|[adx_websiteaccess EntityType](adx_websiteaccess.md)|adx_websiteaccess_AsyncOperations|
|regardingobjectid_adx_websitebinding|[adx_websitebinding EntityType](adx_websitebinding.md)|adx_websitebinding_AsyncOperations|
|regardingobjectid_adx_websitelanguage|[adx_websitelanguage EntityType](adx_websitelanguage.md)|adx_websitelanguage_AsyncOperations|
|regardingobjectid_adx_webtemplate|[adx_webtemplate EntityType](adx_webtemplate.md)|adx_webtemplate_AsyncOperations|
|regardingobjectid_annotation|[annotation EntityType](annotation.md)|Annotation_AsyncOperations|
|regardingobjectid_annualfiscalcalendar|[annualfiscalcalendar EntityType](annualfiscalcalendar.md)|AnnualFiscalCalendar_AsyncOperations|
|regardingobjectid_appointment|[appointment EntityType](appointment.md)|Appointment_AsyncOperations|
|regardingobjectid_bookableresource|[bookableresource EntityType](bookableresource.md)|bookableresource_AsyncOperations|
|regardingobjectid_bookableresourcebooking|[bookableresourcebooking EntityType](bookableresourcebooking.md)|bookableresourcebooking_AsyncOperations|
|regardingobjectid_bookableresourcebookingheader|[bookableresourcebookingheader EntityType](bookableresourcebookingheader.md)|bookableresourcebookingheader_AsyncOperations|
|regardingobjectid_bookableresourcecategory|[bookableresourcecategory EntityType](bookableresourcecategory.md)|bookableresourcecategory_AsyncOperations|
|regardingobjectid_bookableresourcecategoryassn|[bookableresourcecategoryassn EntityType](bookableresourcecategoryassn.md)|bookableresourcecategoryassn_AsyncOperations|
|regardingobjectid_bookableresourcecharacteristic|[bookableresourcecharacteristic EntityType](bookableresourcecharacteristic.md)|bookableresourcecharacteristic_AsyncOperations|
|regardingobjectid_bookableresourcegroup|[bookableresourcegroup EntityType](bookableresourcegroup.md)|bookableresourcegroup_AsyncOperations|
|regardingobjectid_bookingstatus|[bookingstatus EntityType](bookingstatus.md)|bookingstatus_AsyncOperations|
|regardingobjectid_bulkoperation|[bulkoperation EntityType](bulkoperation.md)|BulkOperation_AsyncOperations|
|regardingobjectid_bulkoperationlog|[bulkoperationlog EntityType](bulkoperationlog.md)|BulkOperationLog_AsyncOperations|
|regardingobjectid_businessunit|[businessunit EntityType](businessunit.md)|BusinessUnit_AsyncOperations|
|regardingobjectid_businessunitnewsarticle|[businessunitnewsarticle EntityType](businessunitnewsarticle.md)|BusinessUnitNewsArticle_AsyncOperations|
|regardingobjectid_calendar|[calendar EntityType](calendar.md)|Calendar_AsyncOperations|
|regardingobjectid_campaign|[campaign EntityType](campaign.md)|Campaign_AsyncOperations|
|regardingobjectid_campaignactivity|[campaignactivity EntityType](campaignactivity.md)|CampaignActivity_AsyncOperations|
|regardingobjectid_campaignactivityitem|[campaignactivityitem EntityType](campaignactivityitem.md)|campaignactivityitem_AsyncOperations|
|regardingobjectid_campaignitem|[campaignitem EntityType](campaignitem.md)|campaignitem_AsyncOperations|
|regardingobjectid_campaignresponse|[campaignresponse EntityType](campaignresponse.md)|CampaignResponse_AsyncOperations|
|regardingobjectid_characteristic|[characteristic EntityType](characteristic.md)|characteristic_AsyncOperations|
|regardingobjectid_competitor|[competitor EntityType](competitor.md)|Competitor_AsyncOperations|
|regardingobjectid_competitoraddress|[competitoraddress EntityType](competitoraddress.md)|competitoraddress_AsyncOperations|
|regardingobjectid_competitorproduct|[competitorproduct EntityType](competitorproduct.md)|competitorproduct_AsyncOperations|
|regardingobjectid_competitorsalesliterature|[competitorsalesliterature EntityType](competitorsalesliterature.md)|competitorsalesliterature_AsyncOperations|
|regardingobjectid_connection|[connection EntityType](connection.md)|Connection_AsyncOperations|
|regardingobjectid_connectionrole|[connectionrole EntityType](connectionrole.md)|Connection_Role_AsyncOperations|
|regardingobjectid_constraintbasedgroup|[constraintbasedgroup EntityType](constraintbasedgroup.md)|ConstraintBasedGroup_AsyncOperations|
|regardingobjectid_contact|[contact EntityType](contact.md)|Contact_AsyncOperations|
|regardingobjectid_contactinvoices|[contactinvoices EntityType](contactinvoices.md)|contactinvoices_AsyncOperations|
|regardingobjectid_contactorders|[contactorders EntityType](contactorders.md)|contactorders_AsyncOperations|
|regardingobjectid_contactquotes|[contactquotes EntityType](contactquotes.md)|contactquotes_AsyncOperations|
|regardingobjectid_contract|[contract EntityType](contract.md)|Contract_AsyncOperations|
|regardingobjectid_contractdetail|[contractdetail EntityType](contractdetail.md)|ContractDetail_AsyncOperations|
|regardingobjectid_contracttemplate|[contracttemplate EntityType](contracttemplate.md)|ContractTemplate_AsyncOperations|
|regardingobjectid_customeraddress|[customeraddress EntityType](customeraddress.md)|CustomerAddress_AsyncOperations|
|regardingobjectid_discount|[discount EntityType](discount.md)|Discount_AsyncOperations|
|regardingobjectid_discounttype|[discounttype EntityType](discounttype.md)|DiscountType_AsyncOperations|
|regardingobjectid_dynamicproperty|[dynamicproperty EntityType](dynamicproperty.md)|dynamicproperty_AsyncOperations|
|regardingobjectid_dynamicpropertyassociation|[dynamicpropertyassociation EntityType](dynamicpropertyassociation.md)|dynamicpropertyassociation_AsyncOperations|
|regardingobjectid_dynamicpropertyinstance|[dynamicpropertyinstance EntityType](dynamicpropertyinstance.md)|dynamicpropertyinstance_AsyncOperations|
|regardingobjectid_dynamicpropertyoptionsetitem|[dynamicpropertyoptionsetitem EntityType](dynamicpropertyoptionsetitem.md)|dynamicpropertyoptionsetitem_AsyncOperations|
|regardingobjectid_email|[email EntityType](email.md)|Email_AsyncOperations|
|regardingobjectid_emailserverprofile|[emailserverprofile EntityType](emailserverprofile.md)|emailserverprofile_asyncoperations|
|regardingobjectid_entitlement|[entitlement EntityType](entitlement.md)|entitlement_AsyncOperations|
|regardingobjectid_entitlementchannel|[entitlementchannel EntityType](entitlementchannel.md)|entitlementchannel_AsyncOperations|
|regardingobjectid_entitlementtemplate|[entitlementtemplate EntityType](entitlementtemplate.md)|entitlementtemplate_AsyncOperations|
|regardingobjectid_entitlementtemplatechannel|[entitlementtemplatechannel EntityType](entitlementtemplatechannel.md)|entitlementtemplatechannel_AsyncOperations|
|regardingobjectid_equipment|[equipment EntityType](equipment.md)|Equipment_AsyncOperations|
|regardingobjectid_fax|[fax EntityType](fax.md)|Fax_AsyncOperations|
|regardingobjectid_fixedmonthlyfiscalcalendar|[fixedmonthlyfiscalcalendar EntityType](fixedmonthlyfiscalcalendar.md)|FixedMonthlyFiscalCalendar_AsyncOperations|
|regardingobjectid_goal|[goal EntityType](goal.md)|Goal_AsyncOperations|
|regardingobjectid_goalrollupquery|[goalrollupquery EntityType](goalrollupquery.md)|goalrollupquery_AsyncOperations|
|regardingobjectid_import|[import EntityType](import.md)|Import_AsyncOperations|
|regardingobjectid_importdata|[importdata EntityType](importdata.md)|ImportData_AsyncOperations|
|regardingobjectid_importfile|[importfile EntityType](importfile.md)|ImportFile_AsyncOperations|
|regardingobjectid_importlog|[importlog EntityType](importlog.md)|ImportLog_AsyncOperations|
|regardingobjectid_importmap|[importmap EntityType](importmap.md)|ImportMap_AsyncOperations|
|regardingobjectid_incident|[incident EntityType](incident.md)|Incident_AsyncOperations|
|regardingobjectid_incidentresolution|[incidentresolution EntityType](incidentresolution.md)|IncidentResolution_AsyncOperations|
|regardingobjectid_invoice|[invoice EntityType](invoice.md)|Invoice_AsyncOperations|
|regardingobjectid_invoicedetail|[invoicedetail EntityType](invoicedetail.md)|InvoiceDetail_AsyncOperations|
|regardingobjectid_kbarticle|[kbarticle EntityType](kbarticle.md)|KbArticle_AsyncOperations|
|regardingobjectid_kbarticlecomment|[kbarticlecomment EntityType](kbarticlecomment.md)|KbArticleComment_AsyncOperations|
|regardingobjectid_kbarticletemplate|[kbarticletemplate EntityType](kbarticletemplate.md)|KbArticleTemplate_AsyncOperations|
|regardingobjectid_knowledgearticle|[knowledgearticle EntityType](knowledgearticle.md)|knowledgearticle_AsyncOperations|
|regardingobjectid_knowledgearticleincident|[knowledgearticleincident EntityType](knowledgearticleincident.md)|knowledgearticleincident_AsyncOperations|
|regardingobjectid_knowledgebaserecord|[knowledgebaserecord EntityType](knowledgebaserecord.md)|KnowledgeBaseRecord_AsyncOperations|
|regardingobjectid_lead|[lead EntityType](lead.md)|Lead_AsyncOperations|
|regardingobjectid_leadaddress|[leadaddress EntityType](leadaddress.md)|leadaddress_AsyncOperations|
|regardingobjectid_leadcompetitors|[leadcompetitors EntityType](leadcompetitors.md)|leadcompetitors_AsyncOperations|
|regardingobjectid_leadproduct|[leadproduct EntityType](leadproduct.md)|leadproduct_AsyncOperations|
|regardingobjectid_leadtoopportunitysalesprocess|[leadtoopportunitysalesprocess EntityType](leadtoopportunitysalesprocess.md)|leadtoopportunitysalesprocess_AsyncOperations|
|regardingobjectid_letter|[letter EntityType](letter.md)|Letter_AsyncOperations|
|regardingobjectid_list|[list EntityType](list.md)|List_AsyncOperations|
|regardingobjectid_listmember|[listmember EntityType](listmember.md)|listmember_AsyncOperations|
|regardingobjectid_mailbox|[mailbox EntityType](mailbox.md)|mailbox_asyncoperations|
|regardingobjectid_mailmergetemplate|[mailmergetemplate EntityType](mailmergetemplate.md)|MailMergeTemplate_AsyncOperations|
|regardingobjectid_metric|[metric EntityType](metric.md)|metric_AsyncOperations|
|regardingobjectid_monthlyfiscalcalendar|[monthlyfiscalcalendar EntityType](monthlyfiscalcalendar.md)|MonthlyFiscalCalendar_AsyncOperations|
|regardingobjectid_msdyn_accountpricelist|[msdyn_accountpricelist EntityType](msdyn_accountpricelist.md)|msdyn_accountpricelist_AsyncOperations|
|regardingobjectid_msdyn_actual|[msdyn_actual EntityType](msdyn_actual.md)|msdyn_actual_AsyncOperations|
|regardingobjectid_msdyn_agreement|[msdyn_agreement EntityType](msdyn_agreement.md)|msdyn_agreement_AsyncOperations|
|regardingobjectid_msdyn_agreementbookingdate|[msdyn_agreementbookingdate EntityType](msdyn_agreementbookingdate.md)|msdyn_agreementbookingdate_AsyncOperations|
|regardingobjectid_msdyn_agreementbookingincident|[msdyn_agreementbookingincident EntityType](msdyn_agreementbookingincident.md)|msdyn_agreementbookingincident_AsyncOperations|
|regardingobjectid_msdyn_agreementbookingproduct|[msdyn_agreementbookingproduct EntityType](msdyn_agreementbookingproduct.md)|msdyn_agreementbookingproduct_AsyncOperations|
|regardingobjectid_msdyn_agreementbookingservice|[msdyn_agreementbookingservice EntityType](msdyn_agreementbookingservice.md)|msdyn_agreementbookingservice_AsyncOperations|
|regardingobjectid_msdyn_agreementbookingservicetask|[msdyn_agreementbookingservicetask EntityType](msdyn_agreementbookingservicetask.md)|msdyn_agreementbookingservicetask_AsyncOperations|
|regardingobjectid_msdyn_agreementbookingsetup|[msdyn_agreementbookingsetup EntityType](msdyn_agreementbookingsetup.md)|msdyn_agreementbookingsetup_AsyncOperations|
|regardingobjectid_msdyn_agreementinvoicedate|[msdyn_agreementinvoicedate EntityType](msdyn_agreementinvoicedate.md)|msdyn_agreementinvoicedate_AsyncOperations|
|regardingobjectid_msdyn_agreementinvoiceproduct|[msdyn_agreementinvoiceproduct EntityType](msdyn_agreementinvoiceproduct.md)|msdyn_agreementinvoiceproduct_AsyncOperations|
|regardingobjectid_msdyn_agreementinvoicesetup|[msdyn_agreementinvoicesetup EntityType](msdyn_agreementinvoicesetup.md)|msdyn_agreementinvoicesetup_AsyncOperations|
|regardingobjectid_msdyn_agreementsubstatus|[msdyn_agreementsubstatus EntityType](msdyn_agreementsubstatus.md)|msdyn_agreementsubstatus_AsyncOperations|
|regardingobjectid_msdyn_answer|[msdyn_answer EntityType](msdyn_answer.md)|msdyn_answer_AsyncOperations|
|regardingobjectid_msdyn_approval|[msdyn_approval EntityType](msdyn_approval.md)|msdyn_approval_AsyncOperations|
|regardingobjectid_msdyn_azuredeployment|[msdyn_azuredeployment EntityType](msdyn_azuredeployment.md)|msdyn_azuredeployment_AsyncOperations|
|regardingobjectid_msdyn_batchjob|[msdyn_batchjob EntityType](msdyn_batchjob.md)|msdyn_batchjob_AsyncOperations|
|regardingobjectid_msdyn_bookingalert|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|msdyn_bookingalert_AsyncOperations|
|regardingobjectid_msdyn_bookingalertstatus|[msdyn_bookingalertstatus EntityType](msdyn_bookingalertstatus.md)|msdyn_bookingalertstatus_AsyncOperations|
|regardingobjectid_msdyn_bookingchange|[msdyn_bookingchange EntityType](msdyn_bookingchange.md)|msdyn_bookingchange_AsyncOperations|
|regardingobjectid_msdyn_bookingjournal|[msdyn_bookingjournal EntityType](msdyn_bookingjournal.md)|msdyn_bookingjournal_AsyncOperations|
|regardingobjectid_msdyn_bookingrule|[msdyn_bookingrule EntityType](msdyn_bookingrule.md)|msdyn_bookingrule_AsyncOperations|
|regardingobjectid_msdyn_bookingsetupmetadata|[msdyn_bookingsetupmetadata EntityType](msdyn_bookingsetupmetadata.md)|msdyn_bookingsetupmetadata_AsyncOperations|
|regardingobjectid_msdyn_bookingtimestamp|[msdyn_bookingtimestamp EntityType](msdyn_bookingtimestamp.md)|msdyn_bookingtimestamp_AsyncOperations|
|regardingobjectid_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b|[msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b EntityType](msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b.md)|msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_AsyncOperations|
|regardingobjectid_msdyn_collaboration|[msdyn_collaboration EntityType](msdyn_collaboration.md)|msdyn_collaboration_AsyncOperations|
|regardingobjectid_msdyn_contactpricelist|[msdyn_contactpricelist EntityType](msdyn_contactpricelist.md)|msdyn_contactpricelist_AsyncOperations|
|regardingobjectid_msdyn_contractlineinvoiceschedule|[msdyn_contractlineinvoiceschedule EntityType](msdyn_contractlineinvoiceschedule.md)|msdyn_contractlineinvoiceschedule_AsyncOperations|
|regardingobjectid_msdyn_contractlinescheduleofvalue|[msdyn_contractlinescheduleofvalue EntityType](msdyn_contractlinescheduleofvalue.md)|msdyn_contractlinescheduleofvalue_AsyncOperations|
|regardingobjectid_msdyn_customerasset|[msdyn_customerasset EntityType](msdyn_customerasset.md)|msdyn_customerasset_AsyncOperations|
|regardingobjectid_msdyn_dataexport|[msdyn_dataexport EntityType](msdyn_dataexport.md)|msdyn_dataexport_AsyncOperations|
|regardingobjectid_msdyn_delegation|[msdyn_delegation EntityType](msdyn_delegation.md)|msdyn_delegation_AsyncOperations|
|regardingobjectid_msdyn_estimate|[msdyn_estimate EntityType](msdyn_estimate.md)|msdyn_estimate_AsyncOperations|
|regardingobjectid_msdyn_estimateline|[msdyn_estimateline EntityType](msdyn_estimateline.md)|msdyn_estimateline_AsyncOperations|
|regardingobjectid_msdyn_expense|[msdyn_expense EntityType](msdyn_expense.md)|msdyn_expense_AsyncOperations|
|regardingobjectid_msdyn_expensecategory|[msdyn_expensecategory EntityType](msdyn_expensecategory.md)|msdyn_expensecategory_AsyncOperations|
|regardingobjectid_msdyn_expensereceipt|[msdyn_expensereceipt EntityType](msdyn_expensereceipt.md)|msdyn_expensereceipt_AsyncOperations|
|regardingobjectid_msdyn_fact|[msdyn_fact EntityType](msdyn_fact.md)|msdyn_fact_AsyncOperations|
|regardingobjectid_msdyn_feedbackmapping|[msdyn_feedbackmapping EntityType](msdyn_feedbackmapping.md)|msdyn_feedbackmapping_AsyncOperations|
|regardingobjectid_msdyn_feedbacksubsurvey|[msdyn_feedbacksubsurvey EntityType](msdyn_feedbacksubsurvey.md)|msdyn_feedbacksubsurvey_AsyncOperations|
|regardingobjectid_msdyn_fieldcomputation|[msdyn_fieldcomputation EntityType](msdyn_fieldcomputation.md)|msdyn_fieldcomputation_AsyncOperations|
|regardingobjectid_msdyn_fieldservicepricelistitem|[msdyn_fieldservicepricelistitem EntityType](msdyn_fieldservicepricelistitem.md)|msdyn_fieldservicepricelistitem_AsyncOperations|
|regardingobjectid_msdyn_fieldservicesetting|[msdyn_fieldservicesetting EntityType](msdyn_fieldservicesetting.md)|msdyn_fieldservicesetting_AsyncOperations|
|regardingobjectid_msdyn_fieldservicesystemjob|[msdyn_fieldservicesystemjob EntityType](msdyn_fieldservicesystemjob.md)|msdyn_fieldservicesystemjob_AsyncOperations|
|regardingobjectid_msdyn_findworkevent|[msdyn_findworkevent EntityType](msdyn_findworkevent.md)|msdyn_findworkevent_AsyncOperations|
|regardingobjectid_msdyn_glympseagent|[msdyn_glympseagent EntityType](msdyn_glympseagent.md)|msdyn_glympseagent_AsyncOperations|
|regardingobjectid_msdyn_glympsesetting|[msdyn_glympsesetting EntityType](msdyn_glympsesetting.md)|msdyn_glympsesetting_AsyncOperations|
|regardingobjectid_msdyn_glympsetask|[msdyn_glympsetask EntityType](msdyn_glympsetask.md)|msdyn_glympsetask_AsyncOperations|
|regardingobjectid_msdyn_groupsheader|[msdyn_groupsheader EntityType](msdyn_groupsheader.md)|msdyn_groupsheader_AsyncOperations|
|regardingobjectid_msdyn_image|[msdyn_image EntityType](msdyn_image.md)|msdyn_image_AsyncOperations|
|regardingobjectid_msdyn_imagetokencache|[msdyn_imagetokencache EntityType](msdyn_imagetokencache.md)|msdyn_imagetokencache_AsyncOperations|
|regardingobjectid_msdyn_import|[msdyn_import EntityType](msdyn_import.md)|msdyn_import_AsyncOperations|
|regardingobjectid_msdyn_incidenttype|[msdyn_incidenttype EntityType](msdyn_incidenttype.md)|msdyn_incidenttype_AsyncOperations|
|regardingobjectid_msdyn_incidenttypecharacteristic|[msdyn_incidenttypecharacteristic EntityType](msdyn_incidenttypecharacteristic.md)|msdyn_incidenttypecharacteristic_AsyncOperations|
|regardingobjectid_msdyn_incidenttypeproduct|[msdyn_incidenttypeproduct EntityType](msdyn_incidenttypeproduct.md)|msdyn_incidenttypeproduct_AsyncOperations|
|regardingobjectid_msdyn_incidenttypeservice|[msdyn_incidenttypeservice EntityType](msdyn_incidenttypeservice.md)|msdyn_incidenttypeservice_AsyncOperations|
|regardingobjectid_msdyn_incidenttypeservicetask|[msdyn_incidenttypeservicetask EntityType](msdyn_incidenttypeservicetask.md)|msdyn_incidenttypeservicetask_AsyncOperations|
|regardingobjectid_msdyn_integrationjob|[msdyn_integrationjob EntityType](msdyn_integrationjob.md)|msdyn_integrationjob_AsyncOperations|
|regardingobjectid_msdyn_integrationjobdetail|[msdyn_integrationjobdetail EntityType](msdyn_integrationjobdetail.md)|msdyn_integrationjobdetail_AsyncOperations|
|regardingobjectid_msdyn_inventoryadjustment|[msdyn_inventoryadjustment EntityType](msdyn_inventoryadjustment.md)|msdyn_inventoryadjustment_AsyncOperations|
|regardingobjectid_msdyn_inventoryadjustmentproduct|[msdyn_inventoryadjustmentproduct EntityType](msdyn_inventoryadjustmentproduct.md)|msdyn_inventoryadjustmentproduct_AsyncOperations|
|regardingobjectid_msdyn_inventoryjournal|[msdyn_inventoryjournal EntityType](msdyn_inventoryjournal.md)|msdyn_inventoryjournal_AsyncOperations|
|regardingobjectid_msdyn_inventorytransfer|[msdyn_inventorytransfer EntityType](msdyn_inventorytransfer.md)|msdyn_inventorytransfer_AsyncOperations|
|regardingobjectid_msdyn_invoicefrequency|[msdyn_invoicefrequency EntityType](msdyn_invoicefrequency.md)|msdyn_invoicefrequency_AsyncOperations|
|regardingobjectid_msdyn_invoicefrequencydetail|[msdyn_invoicefrequencydetail EntityType](msdyn_invoicefrequencydetail.md)|msdyn_invoicefrequencydetail_AsyncOperations|
|regardingobjectid_msdyn_invoicelinetransaction|[msdyn_invoicelinetransaction EntityType](msdyn_invoicelinetransaction.md)|msdyn_invoicelinetransaction_AsyncOperations|
|regardingobjectid_msdyn_iotalert|[msdyn_iotalert EntityType](msdyn_iotalert.md)|msdyn_iotalert_AsyncOperations|
|regardingobjectid_msdyn_iotdevice|[msdyn_iotdevice EntityType](msdyn_iotdevice.md)|msdyn_iotdevice_AsyncOperations|
|regardingobjectid_msdyn_iotdevicecategory|[msdyn_iotdevicecategory EntityType](msdyn_iotdevicecategory.md)|msdyn_iotdevicecategory_AsyncOperations|
|regardingobjectid_msdyn_iotdevicecommand|[msdyn_iotdevicecommand EntityType](msdyn_iotdevicecommand.md)|msdyn_iotdevicecommand_AsyncOperations|
|regardingobjectid_msdyn_iotdeviceregistrationhistory|[msdyn_iotdeviceregistrationhistory EntityType](msdyn_iotdeviceregistrationhistory.md)|msdyn_iotdeviceregistrationhistory_AsyncOperations|
|regardingobjectid_msdyn_journal|[msdyn_journal EntityType](msdyn_journal.md)|msdyn_journal_AsyncOperations|
|regardingobjectid_msdyn_journalline|[msdyn_journalline EntityType](msdyn_journalline.md)|msdyn_journalline_AsyncOperations|
|regardingobjectid_msdyn_linkedanswer|[msdyn_linkedanswer EntityType](msdyn_linkedanswer.md)|msdyn_linkedanswer_AsyncOperations|
|regardingobjectid_msdyn_mlresultcache|[msdyn_mlresultcache EntityType](msdyn_mlresultcache.md)|msdyn_mlresultcache_AsyncOperations|
|regardingobjectid_msdyn_opportunitylineresourcecategory|[msdyn_opportunitylineresourcecategory EntityType](msdyn_opportunitylineresourcecategory.md)|msdyn_opportunitylineresourcecategory_AsyncOperations|
|regardingobjectid_msdyn_opportunitylinetransaction|[msdyn_opportunitylinetransaction EntityType](msdyn_opportunitylinetransaction.md)|msdyn_opportunitylinetransaction_AsyncOperations|
|regardingobjectid_msdyn_opportunitylinetransactioncategory|[msdyn_opportunitylinetransactioncategory EntityType](msdyn_opportunitylinetransactioncategory.md)|msdyn_opportunitylinetransactioncategory_AsyncOperations|
|regardingobjectid_msdyn_opportunitylinetransactionclassificatio|[msdyn_opportunitylinetransactionclassificatio EntityType](msdyn_opportunitylinetransactionclassificatio.md)|msdyn_opportunitylinetransactionclassificatio_AsyncOperations|
|regardingobjectid_msdyn_opportunitypricelist|[msdyn_opportunitypricelist EntityType](msdyn_opportunitypricelist.md)|msdyn_opportunitypricelist_AsyncOperations|
|regardingobjectid_msdyn_optimizationrequestbooking|[msdyn_optimizationrequestbooking EntityType](msdyn_optimizationrequestbooking.md)|msdyn_optimizationrequestbooking_AsyncOperations|
|regardingobjectid_msdyn_orderinvoicingdate|[msdyn_orderinvoicingdate EntityType](msdyn_orderinvoicingdate.md)|msdyn_orderinvoicingdate_AsyncOperations|
|regardingobjectid_msdyn_orderinvoicingproduct|[msdyn_orderinvoicingproduct EntityType](msdyn_orderinvoicingproduct.md)|msdyn_orderinvoicingproduct_AsyncOperations|
|regardingobjectid_msdyn_orderinvoicingsetup|[msdyn_orderinvoicingsetup EntityType](msdyn_orderinvoicingsetup.md)|msdyn_orderinvoicingsetup_AsyncOperations|
|regardingobjectid_msdyn_orderinvoicingsetupdate|[msdyn_orderinvoicingsetupdate EntityType](msdyn_orderinvoicingsetupdate.md)|msdyn_orderinvoicingsetupdate_AsyncOperations|
|regardingobjectid_msdyn_orderlineresourcecategory|[msdyn_orderlineresourcecategory EntityType](msdyn_orderlineresourcecategory.md)|msdyn_orderlineresourcecategory_AsyncOperations|
|regardingobjectid_msdyn_orderlinetransaction|[msdyn_orderlinetransaction EntityType](msdyn_orderlinetransaction.md)|msdyn_orderlinetransaction_AsyncOperations|
|regardingobjectid_msdyn_orderlinetransactioncategory|[msdyn_orderlinetransactioncategory EntityType](msdyn_orderlinetransactioncategory.md)|msdyn_orderlinetransactioncategory_AsyncOperations|
|regardingobjectid_msdyn_orderlinetransactionclassification|[msdyn_orderlinetransactionclassification EntityType](msdyn_orderlinetransactionclassification.md)|msdyn_orderlinetransactionclassification_AsyncOperations|
|regardingobjectid_msdyn_orderpricelist|[msdyn_orderpricelist EntityType](msdyn_orderpricelist.md)|msdyn_orderpricelist_AsyncOperations|
|regardingobjectid_msdyn_organizationalunit|[msdyn_organizationalunit EntityType](msdyn_organizationalunit.md)|msdyn_organizationalunit_AsyncOperations|
|regardingobjectid_msdyn_page|[msdyn_page EntityType](msdyn_page.md)|msdyn_page_AsyncOperations|
|regardingobjectid_msdyn_payment|[msdyn_payment EntityType](msdyn_payment.md)|msdyn_payment_AsyncOperations|
|regardingobjectid_msdyn_paymentdetail|[msdyn_paymentdetail EntityType](msdyn_paymentdetail.md)|msdyn_paymentdetail_AsyncOperations|
|regardingobjectid_msdyn_paymentmethod|[msdyn_paymentmethod EntityType](msdyn_paymentmethod.md)|msdyn_paymentmethod_AsyncOperations|
|regardingobjectid_msdyn_paymentterm|[msdyn_paymentterm EntityType](msdyn_paymentterm.md)|msdyn_paymentterm_AsyncOperations|
|regardingobjectid_msdyn_pendinggroupmembers|[msdyn_pendinggroupmembers EntityType](msdyn_pendinggroupmembers.md)|msdyn_pendinggroupmembers_AsyncOperations|
|regardingobjectid_msdyn_postalcode|[msdyn_postalcode EntityType](msdyn_postalcode.md)|msdyn_postalcode_AsyncOperations|
|regardingobjectid_msdyn_priority|[msdyn_priority EntityType](msdyn_priority.md)|msdyn_priority_AsyncOperations|
|regardingobjectid_msdyn_processnotes|[msdyn_processnotes EntityType](msdyn_processnotes.md)|msdyn_processnotes_AsyncOperations|
|regardingobjectid_msdyn_productinventory|[msdyn_productinventory EntityType](msdyn_productinventory.md)|msdyn_productinventory_AsyncOperations|
|regardingobjectid_msdyn_project|[msdyn_project EntityType](msdyn_project.md)|msdyn_project_AsyncOperations|
|regardingobjectid_msdyn_projectapproval|[msdyn_projectapproval EntityType](msdyn_projectapproval.md)|msdyn_projectapproval_AsyncOperations|
|regardingobjectid_msdyn_projectparameter|[msdyn_projectparameter EntityType](msdyn_projectparameter.md)|msdyn_projectparameter_AsyncOperations|
|regardingobjectid_msdyn_projectparameterpricelist|[msdyn_projectparameterpricelist EntityType](msdyn_projectparameterpricelist.md)|msdyn_projectparameterpricelist_AsyncOperations|
|regardingobjectid_msdyn_projectpricelist|[msdyn_projectpricelist EntityType](msdyn_projectpricelist.md)|msdyn_projectpricelist_AsyncOperations|
|regardingobjectid_msdyn_projecttask|[msdyn_projecttask EntityType](msdyn_projecttask.md)|msdyn_projecttask_AsyncOperations|
|regardingobjectid_msdyn_projecttaskdependency|[msdyn_projecttaskdependency EntityType](msdyn_projecttaskdependency.md)|msdyn_projecttaskdependency_AsyncOperations|
|regardingobjectid_msdyn_projecttaskstatususer|[msdyn_projecttaskstatususer EntityType](msdyn_projecttaskstatususer.md)|msdyn_projecttaskstatususer_AsyncOperations|
|regardingobjectid_msdyn_projectteam|[msdyn_projectteam EntityType](msdyn_projectteam.md)|msdyn_projectteam_AsyncOperations|
|regardingobjectid_msdyn_projectteammembersignup|[msdyn_projectteammembersignup EntityType](msdyn_projectteammembersignup.md)|msdyn_projectteammembersignup_AsyncOperations|
|regardingobjectid_msdyn_projecttransactioncategory|[msdyn_projecttransactioncategory EntityType](msdyn_projecttransactioncategory.md)|msdyn_projecttransactioncategory_AsyncOperations|
|regardingobjectid_msdyn_purchaseorder|[msdyn_purchaseorder EntityType](msdyn_purchaseorder.md)|msdyn_purchaseorder_AsyncOperations|
|regardingobjectid_msdyn_purchaseorderbill|[msdyn_purchaseorderbill EntityType](msdyn_purchaseorderbill.md)|msdyn_purchaseorderbill_AsyncOperations|
|regardingobjectid_msdyn_purchaseorderproduct|[msdyn_purchaseorderproduct EntityType](msdyn_purchaseorderproduct.md)|msdyn_purchaseorderproduct_AsyncOperations|
|regardingobjectid_msdyn_purchaseorderreceipt|[msdyn_purchaseorderreceipt EntityType](msdyn_purchaseorderreceipt.md)|msdyn_purchaseorderreceipt_AsyncOperations|
|regardingobjectid_msdyn_purchaseorderreceiptproduct|[msdyn_purchaseorderreceiptproduct EntityType](msdyn_purchaseorderreceiptproduct.md)|msdyn_purchaseorderreceiptproduct_AsyncOperations|
|regardingobjectid_msdyn_purchaseordersubstatus|[msdyn_purchaseordersubstatus EntityType](msdyn_purchaseordersubstatus.md)|msdyn_purchaseordersubstatus_AsyncOperations|
|regardingobjectid_msdyn_question|[msdyn_question EntityType](msdyn_question.md)|msdyn_question_AsyncOperations|
|regardingobjectid_msdyn_questiongroup|[msdyn_questiongroup EntityType](msdyn_questiongroup.md)|msdyn_questiongroup_AsyncOperations|
|regardingobjectid_msdyn_questionresponse|[msdyn_questionresponse EntityType](msdyn_questionresponse.md)|msdyn_questionresponse_AsyncOperations|
|regardingobjectid_msdyn_questiontype|[msdyn_questiontype EntityType](msdyn_questiontype.md)|msdyn_questiontype_AsyncOperations|
|regardingobjectid_msdyn_quotebookingincident|[msdyn_quotebookingincident EntityType](msdyn_quotebookingincident.md)|msdyn_quotebookingincident_AsyncOperations|
|regardingobjectid_msdyn_quotebookingproduct|[msdyn_quotebookingproduct EntityType](msdyn_quotebookingproduct.md)|msdyn_quotebookingproduct_AsyncOperations|
|regardingobjectid_msdyn_quotebookingservice|[msdyn_quotebookingservice EntityType](msdyn_quotebookingservice.md)|msdyn_quotebookingservice_AsyncOperations|
|regardingobjectid_msdyn_quotebookingservicetask|[msdyn_quotebookingservicetask EntityType](msdyn_quotebookingservicetask.md)|msdyn_quotebookingservicetask_AsyncOperations|
|regardingobjectid_msdyn_quotebookingsetup|[msdyn_quotebookingsetup EntityType](msdyn_quotebookingsetup.md)|msdyn_quotebookingsetup_AsyncOperations|
|regardingobjectid_msdyn_quoteinvoicingproduct|[msdyn_quoteinvoicingproduct EntityType](msdyn_quoteinvoicingproduct.md)|msdyn_quoteinvoicingproduct_AsyncOperations|
|regardingobjectid_msdyn_quoteinvoicingsetup|[msdyn_quoteinvoicingsetup EntityType](msdyn_quoteinvoicingsetup.md)|msdyn_quoteinvoicingsetup_AsyncOperations|
|regardingobjectid_msdyn_quotelineanalyticsbreakdown|[msdyn_quotelineanalyticsbreakdown EntityType](msdyn_quotelineanalyticsbreakdown.md)|msdyn_quotelineanalyticsbreakdown_AsyncOperations|
|regardingobjectid_msdyn_quotelineinvoiceschedule|[msdyn_quotelineinvoiceschedule EntityType](msdyn_quotelineinvoiceschedule.md)|msdyn_quotelineinvoiceschedule_AsyncOperations|
|regardingobjectid_msdyn_quotelineresourcecategory|[msdyn_quotelineresourcecategory EntityType](msdyn_quotelineresourcecategory.md)|msdyn_quotelineresourcecategory_AsyncOperations|
|regardingobjectid_msdyn_quotelinescheduleofvalue|[msdyn_quotelinescheduleofvalue EntityType](msdyn_quotelinescheduleofvalue.md)|msdyn_quotelinescheduleofvalue_AsyncOperations|
|regardingobjectid_msdyn_quotelinetransaction|[msdyn_quotelinetransaction EntityType](msdyn_quotelinetransaction.md)|msdyn_quotelinetransaction_AsyncOperations|
|regardingobjectid_msdyn_quotelinetransactioncategory|[msdyn_quotelinetransactioncategory EntityType](msdyn_quotelinetransactioncategory.md)|msdyn_quotelinetransactioncategory_AsyncOperations|
|regardingobjectid_msdyn_quotelinetransactionclassification|[msdyn_quotelinetransactionclassification EntityType](msdyn_quotelinetransactionclassification.md)|msdyn_quotelinetransactionclassification_AsyncOperations|
|regardingobjectid_msdyn_quotepricelist|[msdyn_quotepricelist EntityType](msdyn_quotepricelist.md)|msdyn_quotepricelist_AsyncOperations|
|regardingobjectid_msdyn_requirementcharacteristic|[msdyn_requirementcharacteristic EntityType](msdyn_requirementcharacteristic.md)|msdyn_requirementcharacteristic_AsyncOperations|
|regardingobjectid_msdyn_requirementorganizationunit|[msdyn_requirementorganizationunit EntityType](msdyn_requirementorganizationunit.md)|msdyn_requirementorganizationunit_AsyncOperations|
|regardingobjectid_msdyn_requirementresourcecategory|[msdyn_requirementresourcecategory EntityType](msdyn_requirementresourcecategory.md)|msdyn_requirementresourcecategory_AsyncOperations|
|regardingobjectid_msdyn_requirementresourcepreference|[msdyn_requirementresourcepreference EntityType](msdyn_requirementresourcepreference.md)|msdyn_requirementresourcepreference_AsyncOperations|
|regardingobjectid_msdyn_requirementstatus|[msdyn_requirementstatus EntityType](msdyn_requirementstatus.md)|msdyn_requirementstatus_AsyncOperations|
|regardingobjectid_msdyn_resourceassignment|[msdyn_resourceassignment EntityType](msdyn_resourceassignment.md)|msdyn_resourceassignment_AsyncOperations|
|regardingobjectid_msdyn_resourceassignmentdetail|[msdyn_resourceassignmentdetail EntityType](msdyn_resourceassignmentdetail.md)|msdyn_resourceassignmentdetail_AsyncOperations|
|regardingobjectid_msdyn_resourcecategorypricelevel|[msdyn_resourcecategorypricelevel EntityType](msdyn_resourcecategorypricelevel.md)|msdyn_resourcecategorypricelevel_AsyncOperations|
|regardingobjectid_msdyn_resourcepaytype|[msdyn_resourcepaytype EntityType](msdyn_resourcepaytype.md)|msdyn_resourcepaytype_AsyncOperations|
|regardingobjectid_msdyn_resourcerequest|[msdyn_resourcerequest EntityType](msdyn_resourcerequest.md)|msdyn_resourcerequest_AsyncOperations|
|regardingobjectid_msdyn_resourcerequirement|[msdyn_resourcerequirement EntityType](msdyn_resourcerequirement.md)|msdyn_resourcerequirement_AsyncOperations|
|regardingobjectid_msdyn_resourcerequirementdetail|[msdyn_resourcerequirementdetail EntityType](msdyn_resourcerequirementdetail.md)|msdyn_resourcerequirementdetail_AsyncOperations|
|regardingobjectid_msdyn_resourceterritory|[msdyn_resourceterritory EntityType](msdyn_resourceterritory.md)|msdyn_resourceterritory_AsyncOperations|
|regardingobjectid_msdyn_responseaction|[msdyn_responseaction EntityType](msdyn_responseaction.md)|msdyn_responseaction_AsyncOperations|
|regardingobjectid_msdyn_responseblobstore|[msdyn_responseblobstore EntityType](msdyn_responseblobstore.md)|msdyn_responseblobstore_AsyncOperations|
|regardingobjectid_msdyn_responsecondition|[msdyn_responsecondition EntityType](msdyn_responsecondition.md)|msdyn_responsecondition_AsyncOperations|
|regardingobjectid_msdyn_responseoutcome|[msdyn_responseoutcome EntityType](msdyn_responseoutcome.md)|msdyn_responseoutcome_AsyncOperations|
|regardingobjectid_msdyn_responserouting|[msdyn_responserouting EntityType](msdyn_responserouting.md)|msdyn_responserouting_AsyncOperations|
|regardingobjectid_msdyn_rma|[msdyn_rma EntityType](msdyn_rma.md)|msdyn_rma_AsyncOperations|
|regardingobjectid_msdyn_rmaproduct|[msdyn_rmaproduct EntityType](msdyn_rmaproduct.md)|msdyn_rmaproduct_AsyncOperations|
|regardingobjectid_msdyn_rmareceipt|[msdyn_rmareceipt EntityType](msdyn_rmareceipt.md)|msdyn_rmareceipt_AsyncOperations|
|regardingobjectid_msdyn_rmareceiptproduct|[msdyn_rmareceiptproduct EntityType](msdyn_rmareceiptproduct.md)|msdyn_rmareceiptproduct_AsyncOperations|
|regardingobjectid_msdyn_rmasubstatus|[msdyn_rmasubstatus EntityType](msdyn_rmasubstatus.md)|msdyn_rmasubstatus_AsyncOperations|
|regardingobjectid_msdyn_rolecompetencyrequirement|[msdyn_rolecompetencyrequirement EntityType](msdyn_rolecompetencyrequirement.md)|msdyn_rolecompetencyrequirement_AsyncOperations|
|regardingobjectid_msdyn_roleutilization|[msdyn_roleutilization EntityType](msdyn_roleutilization.md)|msdyn_roleutilization_AsyncOperations|
|regardingobjectid_msdyn_routingengineconfiguration|[msdyn_routingengineconfiguration EntityType](msdyn_routingengineconfiguration.md)|msdyn_routingengineconfiguration_AsyncOperations|
|regardingobjectid_msdyn_routingjobconfiguration|[msdyn_routingjobconfiguration EntityType](msdyn_routingjobconfiguration.md)|msdyn_routingjobconfiguration_AsyncOperations|
|regardingobjectid_msdyn_routingoptimizationrequest|[msdyn_routingoptimizationrequest EntityType](msdyn_routingoptimizationrequest.md)|msdyn_routingoptimizationrequest_AsyncOperations|
|regardingobjectid_msdyn_routingprofileconfiguration|[msdyn_routingprofileconfiguration EntityType](msdyn_routingprofileconfiguration.md)|msdyn_routingprofileconfiguration_AsyncOperations|
|regardingobjectid_msdyn_rtv|[msdyn_rtv EntityType](msdyn_rtv.md)|msdyn_rtv_AsyncOperations|
|regardingobjectid_msdyn_rtvproduct|[msdyn_rtvproduct EntityType](msdyn_rtvproduct.md)|msdyn_rtvproduct_AsyncOperations|
|regardingobjectid_msdyn_rtvsubstatus|[msdyn_rtvsubstatus EntityType](msdyn_rtvsubstatus.md)|msdyn_rtvsubstatus_AsyncOperations|
|regardingobjectid_msdyn_scheduleboardsetting|[msdyn_scheduleboardsetting EntityType](msdyn_scheduleboardsetting.md)|msdyn_scheduleboardsetting_AsyncOperations|
|regardingobjectid_msdyn_schedulingoptimizationhealthlog|[msdyn_schedulingoptimizationhealthlog EntityType](msdyn_schedulingoptimizationhealthlog.md)|msdyn_schedulingoptimizationhealthlog_AsyncOperations|
|regardingobjectid_msdyn_schedulingparameter|[msdyn_schedulingparameter EntityType](msdyn_schedulingparameter.md)|msdyn_schedulingparameter_AsyncOperations|
|regardingobjectid_msdyn_section|[msdyn_section EntityType](msdyn_section.md)|msdyn_section_AsyncOperations|
|regardingobjectid_msdyn_servicetasktype|[msdyn_servicetasktype EntityType](msdyn_servicetasktype.md)|msdyn_servicetasktype_AsyncOperations|
|regardingobjectid_msdyn_shipvia|[msdyn_shipvia EntityType](msdyn_shipvia.md)|msdyn_shipvia_AsyncOperations|
|regardingobjectid_msdyn_survey|[msdyn_survey EntityType](msdyn_survey.md)|msdyn_survey_AsyncOperations|
|regardingobjectid_msdyn_surveyinvite|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|msdyn_surveyinvite_AsyncOperations|
|regardingobjectid_msdyn_surveylog|[msdyn_surveylog EntityType](msdyn_surveylog.md)|msdyn_surveylog_AsyncOperations|
|regardingobjectid_msdyn_surveyresponse|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|msdyn_surveyresponse_AsyncOperations|
|regardingobjectid_msdyn_systemuserschedulersetting|[msdyn_systemuserschedulersetting EntityType](msdyn_systemuserschedulersetting.md)|msdyn_systemuserschedulersetting_AsyncOperations|
|regardingobjectid_msdyn_taxcode|[msdyn_taxcode EntityType](msdyn_taxcode.md)|msdyn_taxcode_AsyncOperations|
|regardingobjectid_msdyn_taxcodedetail|[msdyn_taxcodedetail EntityType](msdyn_taxcodedetail.md)|msdyn_taxcodedetail_AsyncOperations|
|regardingobjectid_msdyn_theme|[msdyn_theme EntityType](msdyn_theme.md)|msdyn_theme_AsyncOperations|
|regardingobjectid_msdyn_timeentry|[msdyn_timeentry EntityType](msdyn_timeentry.md)|msdyn_timeentry_AsyncOperations|
|regardingobjectid_msdyn_timegroup|[msdyn_timegroup EntityType](msdyn_timegroup.md)|msdyn_timegroup_AsyncOperations|
|regardingobjectid_msdyn_timegroupdetail|[msdyn_timegroupdetail EntityType](msdyn_timegroupdetail.md)|msdyn_timegroupdetail_AsyncOperations|
|regardingobjectid_msdyn_timeoffcalendar|[msdyn_timeoffcalendar EntityType](msdyn_timeoffcalendar.md)|msdyn_timeoffcalendar_AsyncOperations|
|regardingobjectid_msdyn_timeoffrequest|[msdyn_timeoffrequest EntityType](msdyn_timeoffrequest.md)|msdyn_timeoffrequest_AsyncOperations|
|regardingobjectid_msdyn_transactioncategory|[msdyn_transactioncategory EntityType](msdyn_transactioncategory.md)|msdyn_transactioncategory_AsyncOperations|
|regardingobjectid_msdyn_transactioncategoryclassification|[msdyn_transactioncategoryclassification EntityType](msdyn_transactioncategoryclassification.md)|msdyn_transactioncategoryclassification_AsyncOperations|
|regardingobjectid_msdyn_transactioncategoryhierarchyelement|[msdyn_transactioncategoryhierarchyelement EntityType](msdyn_transactioncategoryhierarchyelement.md)|msdyn_transactioncategoryhierarchyelement_AsyncOperations|
|regardingobjectid_msdyn_transactioncategorypricelevel|[msdyn_transactioncategorypricelevel EntityType](msdyn_transactioncategorypricelevel.md)|msdyn_transactioncategorypricelevel_AsyncOperations|
|regardingobjectid_msdyn_transactionconnection|[msdyn_transactionconnection EntityType](msdyn_transactionconnection.md)|msdyn_transactionconnection_AsyncOperations|
|regardingobjectid_msdyn_transactionorigin|[msdyn_transactionorigin EntityType](msdyn_transactionorigin.md)|msdyn_transactionorigin_AsyncOperations|
|regardingobjectid_msdyn_transactiontype|[msdyn_transactiontype EntityType](msdyn_transactiontype.md)|msdyn_transactiontype_AsyncOperations|
|regardingobjectid_msdyn_uniquenumber|[msdyn_uniquenumber EntityType](msdyn_uniquenumber.md)|msdyn_uniquenumber_AsyncOperations|
|regardingobjectid_msdyn_userworkhistory|[msdyn_userworkhistory EntityType](msdyn_userworkhistory.md)|msdyn_userworkhistory_AsyncOperations|
|regardingobjectid_msdyn_vocconfiguration|[msdyn_vocconfiguration EntityType](msdyn_vocconfiguration.md)|msdyn_vocconfiguration_AsyncOperations|
|regardingobjectid_msdyn_warehouse|[msdyn_warehouse EntityType](msdyn_warehouse.md)|msdyn_warehouse_AsyncOperations|
|regardingobjectid_msdyn_workhourtemplate|[msdyn_workhourtemplate EntityType](msdyn_workhourtemplate.md)|msdyn_workhourtemplate_AsyncOperations|
|regardingobjectid_msdyn_workorder|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_workorder_AsyncOperations|
|regardingobjectid_msdyn_workordercharacteristic|[msdyn_workordercharacteristic EntityType](msdyn_workordercharacteristic.md)|msdyn_workordercharacteristic_AsyncOperations|
|regardingobjectid_msdyn_workorderdetailsgenerationqueue|[msdyn_workorderdetailsgenerationqueue EntityType](msdyn_workorderdetailsgenerationqueue.md)|msdyn_workorderdetailsgenerationqueue_AsyncOperations|
|regardingobjectid_msdyn_workorderincident|[msdyn_workorderincident EntityType](msdyn_workorderincident.md)|msdyn_workorderincident_AsyncOperations|
|regardingobjectid_msdyn_workorderproduct|[msdyn_workorderproduct EntityType](msdyn_workorderproduct.md)|msdyn_workorderproduct_AsyncOperations|
|regardingobjectid_msdyn_workorderresourcerestriction|[msdyn_workorderresourcerestriction EntityType](msdyn_workorderresourcerestriction.md)|msdyn_workorderresourcerestriction_AsyncOperations|
|regardingobjectid_msdyn_workorderservice|[msdyn_workorderservice EntityType](msdyn_workorderservice.md)|msdyn_workorderservice_AsyncOperations|
|regardingobjectid_msdyn_workorderservicetask|[msdyn_workorderservicetask EntityType](msdyn_workorderservicetask.md)|msdyn_workorderservicetask_AsyncOperations|
|regardingobjectid_msdyn_workordersubstatus|[msdyn_workordersubstatus EntityType](msdyn_workordersubstatus.md)|msdyn_workordersubstatus_AsyncOperations|
|regardingobjectid_msdyn_workordertype|[msdyn_workordertype EntityType](msdyn_workordertype.md)|msdyn_workordertype_AsyncOperations|
|regardingobjectid_msdyncrm_appointmentactivitymarketingtemplate|[msdyncrm_appointmentactivitymarketingtemplate EntityType](msdyncrm_appointmentactivitymarketingtemplate.md)|msdyncrm_appointmentactivitymarketingtemplate_AsyncOperations|
|regardingobjectid_msdyncrm_campaigncustomchannelactivity|[msdyncrm_campaigncustomchannelactivity EntityType](msdyncrm_campaigncustomchannelactivity.md)|msdyncrm_campaigncustomchannelactivity_AsyncOperations|
|regardingobjectid_msdyncrm_contentsettings|[msdyncrm_contentsettings EntityType](msdyncrm_contentsettings.md)|msdyncrm_contentsettings_AsyncOperations|
|regardingobjectid_msdyncrm_customerinsightsinfo|[msdyncrm_customerinsightsinfo EntityType](msdyncrm_customerinsightsinfo.md)|msdyncrm_customerinsightsinfo_AsyncOperations|
|regardingobjectid_msdyncrm_customerjourney|[msdyncrm_customerjourney EntityType](msdyncrm_customerjourney.md)|msdyncrm_customerjourney_AsyncOperations|
|regardingobjectid_msdyncrm_customerjourneyiteration|[msdyncrm_customerjourneyiteration EntityType](msdyncrm_customerjourneyiteration.md)|msdyncrm_customerjourneyiteration_AsyncOperations|
|regardingobjectid_msdyncrm_customerjourneytemplate|[msdyncrm_customerjourneytemplate EntityType](msdyncrm_customerjourneytemplate.md)|msdyncrm_customerjourneytemplate_AsyncOperations|
|regardingobjectid_msdyncrm_customerjourneyworkflowlink|[msdyncrm_customerjourneyworkflowlink EntityType](msdyncrm_customerjourneyworkflowlink.md)|msdyncrm_customerjourneyworkflowlink_AsyncOperations|
|regardingobjectid_msdyncrm_file|[msdyncrm_file EntityType](msdyncrm_file.md)|msdyncrm_file_AsyncOperations|
|regardingobjectid_msdyncrm_formpage|[msdyncrm_formpage EntityType](msdyncrm_formpage.md)|msdyncrm_formpage_AsyncOperations|
|regardingobjectid_msdyncrm_formpagetemplate|[msdyncrm_formpagetemplate EntityType](msdyncrm_formpagetemplate.md)|msdyncrm_formpagetemplate_AsyncOperations|
|regardingobjectid_msdyncrm_geopin|[msdyncrm_geopin EntityType](msdyncrm_geopin.md)|msdyncrm_geopin_AsyncOperations|
|regardingobjectid_msdyncrm_keyword|[msdyncrm_keyword EntityType](msdyncrm_keyword.md)|msdyncrm_keyword_AsyncOperations|
|regardingobjectid_msdyncrm_leadscore|[msdyncrm_leadscore EntityType](msdyncrm_leadscore.md)|msdyncrm_leadscore_AsyncOperations|
|regardingobjectid_msdyncrm_leadscoremodel|[msdyncrm_leadscoremodel EntityType](msdyncrm_leadscoremodel.md)|msdyncrm_leadscoremodel_AsyncOperations|
|regardingobjectid_msdyncrm_leadtoopportunity|[msdyncrm_leadtoopportunity EntityType](msdyncrm_leadtoopportunity.md)|msdyncrm_leadtoopportunity_AsyncOperations|
|regardingobjectid_msdyncrm_linkedinaccount|[msdyncrm_linkedinaccount EntityType](msdyncrm_linkedinaccount.md)|msdyncrm_linkedinaccount_AsyncOperations|
|regardingobjectid_msdyncrm_linkedinactivity|[msdyncrm_linkedinactivity EntityType](msdyncrm_linkedinactivity.md)|msdyncrm_linkedinactivity_AsyncOperations|
|regardingobjectid_msdyncrm_linkedincampaign|[msdyncrm_linkedincampaign EntityType](msdyncrm_linkedincampaign.md)|msdyncrm_linkedincampaign_AsyncOperations|
|regardingobjectid_msdyncrm_linkedinconfiguration|[msdyncrm_linkedinconfiguration EntityType](msdyncrm_linkedinconfiguration.md)|msdyncrm_linkedinconfiguration_AsyncOperations|
|regardingobjectid_msdyncrm_linkedinfieldmapping|[msdyncrm_linkedinfieldmapping EntityType](msdyncrm_linkedinfieldmapping.md)|msdyncrm_linkedinfieldmapping_AsyncOperations|
|regardingobjectid_msdyncrm_linkedinform|[msdyncrm_linkedinform EntityType](msdyncrm_linkedinform.md)|msdyncrm_linkedinform_AsyncOperations|
|regardingobjectid_msdyncrm_linkedinformanswer|[msdyncrm_linkedinformanswer EntityType](msdyncrm_linkedinformanswer.md)|msdyncrm_linkedinformanswer_AsyncOperations|
|regardingobjectid_msdyncrm_linkedinformquestion|[msdyncrm_linkedinformquestion EntityType](msdyncrm_linkedinformquestion.md)|msdyncrm_linkedinformquestion_AsyncOperations|
|regardingobjectid_msdyncrm_linkedinformsubmission|[msdyncrm_linkedinformsubmission EntityType](msdyncrm_linkedinformsubmission.md)|msdyncrm_linkedinformsubmission_AsyncOperations|
|regardingobjectid_msdyncrm_linkedinleadmatchingstrategy|[msdyncrm_linkedinleadmatchingstrategy EntityType](msdyncrm_linkedinleadmatchingstrategy.md)|msdyncrm_linkedinleadmatchingstrategy_AsyncOperations|
|regardingobjectid_msdyncrm_linkedinuserprofile|[msdyncrm_linkedinuserprofile EntityType](msdyncrm_linkedinuserprofile.md)|msdyncrm_linkedinuserprofile_AsyncOperations|
|regardingobjectid_msdyncrm_marketingconfiguration|[msdyncrm_marketingconfiguration EntityType](msdyncrm_marketingconfiguration.md)|msdyncrm_marketingconfiguration_AsyncOperations|
|regardingobjectid_msdyncrm_marketingdynamiccontentmetadata|[msdyncrm_marketingdynamiccontentmetadata EntityType](msdyncrm_marketingdynamiccontentmetadata.md)|msdyncrm_marketingdynamiccontentmetadata_AsyncOperations|
|regardingobjectid_msdyncrm_marketingemail|[msdyncrm_marketingemail EntityType](msdyncrm_marketingemail.md)|msdyncrm_marketingemail_AsyncOperations|
|regardingobjectid_msdyncrm_marketingemaildynamiccontentmetadata|[msdyncrm_marketingemaildynamiccontentmetadata EntityType](msdyncrm_marketingemaildynamiccontentmetadata.md)|msdyncrm_marketingemaildynamiccontentmetadata_AsyncOperations|
|regardingobjectid_msdyncrm_marketingemailtemplate|[msdyncrm_marketingemailtemplate EntityType](msdyncrm_marketingemailtemplate.md)|msdyncrm_marketingemailtemplate_AsyncOperations|
|regardingobjectid_msdyncrm_marketingemailtestsend|[msdyncrm_marketingemailtestsend EntityType](msdyncrm_marketingemailtestsend.md)|msdyncrm_marketingemailtestsend_AsyncOperations|
|regardingobjectid_msdyncrm_marketingform|[msdyncrm_marketingform EntityType](msdyncrm_marketingform.md)|msdyncrm_marketingform_AsyncOperations|
|regardingobjectid_msdyncrm_marketingformfield|[msdyncrm_marketingformfield EntityType](msdyncrm_marketingformfield.md)|msdyncrm_marketingformfield_AsyncOperations|
|regardingobjectid_msdyncrm_marketingformtemplate|[msdyncrm_marketingformtemplate EntityType](msdyncrm_marketingformtemplate.md)|msdyncrm_marketingformtemplate_AsyncOperations|
|regardingobjectid_msdyncrm_marketingpage|[msdyncrm_marketingpage EntityType](msdyncrm_marketingpage.md)|msdyncrm_marketingpage_AsyncOperations|
|regardingobjectid_msdyncrm_marketingpageconfiguration|[msdyncrm_marketingpageconfiguration EntityType](msdyncrm_marketingpageconfiguration.md)|msdyncrm_marketingpageconfiguration_AsyncOperations|
|regardingobjectid_msdyncrm_marketingpagetemplate|[msdyncrm_marketingpagetemplate EntityType](msdyncrm_marketingpagetemplate.md)|msdyncrm_marketingpagetemplate_AsyncOperations|
|regardingobjectid_msdyncrm_matchingstrategy|[msdyncrm_matchingstrategy EntityType](msdyncrm_matchingstrategy.md)|msdyncrm_matchingstrategy_AsyncOperations|
|regardingobjectid_msdyncrm_mktactivity|[msdyncrm_mktactivity EntityType](msdyncrm_mktactivity.md)|msdyncrm_mktactivity_AsyncOperations|
|regardingobjectid_msdyncrm_phonecallactivitymarketingtemplate|[msdyncrm_phonecallactivitymarketingtemplate EntityType](msdyncrm_phonecallactivitymarketingtemplate.md)|msdyncrm_phonecallactivitymarketingtemplate_AsyncOperations|
|regardingobjectid_msdyncrm_portalsettings|[msdyncrm_portalsettings EntityType](msdyncrm_portalsettings.md)|msdyncrm_portalsettings_AsyncOperations|
|regardingobjectid_msdyncrm_redirecturl|[msdyncrm_redirecturl EntityType](msdyncrm_redirecturl.md)|msdyncrm_redirecturl_AsyncOperations|
|regardingobjectid_msdyncrm_segment|[msdyncrm_segment EntityType](msdyncrm_segment.md)|msdyncrm_segment_AsyncOperations|
|regardingobjectid_msdyncrm_taskactivitymarketingtemplate|[msdyncrm_taskactivitymarketingtemplate EntityType](msdyncrm_taskactivitymarketingtemplate.md)|msdyncrm_taskactivitymarketingtemplate_AsyncOperations|
|regardingobjectid_msdyncrm_uicconfig|[msdyncrm_uicconfig EntityType](msdyncrm_uicconfig.md)|msdyncrm_uicconfig_AsyncOperations|
|regardingobjectid_msdyncrm_usergeoregion|[msdyncrm_usergeoregion EntityType](msdyncrm_usergeoregion.md)|msdyncrm_usergeoregion_AsyncOperations|
|regardingobjectid_msdyncrm_website|[msdyncrm_website EntityType](msdyncrm_website.md)|msdyncrm_website_AsyncOperations|
|regardingobjectid_msevtmgt_attendeepass|[msevtmgt_attendeepass EntityType](msevtmgt_attendeepass.md)|msevtmgt_attendeepass_AsyncOperations|
|regardingobjectid_msevtmgt_authenticationsettings|[msevtmgt_authenticationsettings EntityType](msevtmgt_authenticationsettings.md)|msevtmgt_authenticationsettings_AsyncOperations|
|regardingobjectid_msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99|[msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99 EntityType](msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99.md)|msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99_AsyncOperations|
|regardingobjectid_msevtmgt_building|[msevtmgt_building EntityType](msevtmgt_building.md)|msevtmgt_building_AsyncOperations|
|regardingobjectid_msevtmgt_checkin|[msevtmgt_checkin EntityType](msevtmgt_checkin.md)|msevtmgt_checkin_AsyncOperations|
|regardingobjectid_msevtmgt_entitycounter|[msevtmgt_entitycounter EntityType](msevtmgt_entitycounter.md)|msevtmgt_entitycounter_AsyncOperations|
|regardingobjectid_msevtmgt_event|[msevtmgt_event EntityType](msevtmgt_event.md)|msevtmgt_event_AsyncOperations|
|regardingobjectid_msevtmgt_eventadministration|[msevtmgt_eventadministration EntityType](msevtmgt_eventadministration.md)|msevtmgt_eventadministration_AsyncOperations|
|regardingobjectid_msevtmgt_eventmanagementconfiguration|[msevtmgt_eventmanagementconfiguration EntityType](msevtmgt_eventmanagementconfiguration.md)|msevtmgt_eventmanagementconfiguration_AsyncOperations|
|regardingobjectid_msevtmgt_eventpurchase|[msevtmgt_eventpurchase EntityType](msevtmgt_eventpurchase.md)|msevtmgt_eventpurchase_AsyncOperations|
|regardingobjectid_msevtmgt_eventpurchaseattendee|[msevtmgt_eventpurchaseattendee EntityType](msevtmgt_eventpurchaseattendee.md)|msevtmgt_eventpurchaseattendee_AsyncOperations|
|regardingobjectid_msevtmgt_eventpurchasepass|[msevtmgt_eventpurchasepass EntityType](msevtmgt_eventpurchasepass.md)|msevtmgt_eventpurchasepass_AsyncOperations|
|regardingobjectid_msevtmgt_eventregistration|[msevtmgt_eventregistration EntityType](msevtmgt_eventregistration.md)|msevtmgt_eventregistration_AsyncOperations|
|regardingobjectid_msevtmgt_eventteammember|[msevtmgt_eventteammember EntityType](msevtmgt_eventteammember.md)|msevtmgt_eventteammember_AsyncOperations|
|regardingobjectid_msevtmgt_eventvendor|[msevtmgt_eventvendor EntityType](msevtmgt_eventvendor.md)|msevtmgt_eventvendor_AsyncOperations|
|regardingobjectid_msevtmgt_hotel|[msevtmgt_hotel EntityType](msevtmgt_hotel.md)|msevtmgt_hotel_AsyncOperations|
|regardingobjectid_msevtmgt_hotelroomallocation|[msevtmgt_hotelroomallocation EntityType](msevtmgt_hotelroomallocation.md)|msevtmgt_hotelroomallocation_AsyncOperations|
|regardingobjectid_msevtmgt_hotelroomreservation|[msevtmgt_hotelroomreservation EntityType](msevtmgt_hotelroomreservation.md)|msevtmgt_hotelroomreservation_AsyncOperations|
|regardingobjectid_msevtmgt_layout|[msevtmgt_layout EntityType](msevtmgt_layout.md)|msevtmgt_layout_AsyncOperations|
|regardingobjectid_msevtmgt_pass|[msevtmgt_pass EntityType](msevtmgt_pass.md)|msevtmgt_pass_AsyncOperations|
|regardingobjectid_msevtmgt_room|[msevtmgt_room EntityType](msevtmgt_room.md)|msevtmgt_room_AsyncOperations|
|regardingobjectid_msevtmgt_session|[msevtmgt_session EntityType](msevtmgt_session.md)|msevtmgt_session_AsyncOperations|
|regardingobjectid_msevtmgt_sessionregistration|[msevtmgt_sessionregistration EntityType](msevtmgt_sessionregistration.md)|msevtmgt_sessionregistration_AsyncOperations|
|regardingobjectid_msevtmgt_sessiontrack|[msevtmgt_sessiontrack EntityType](msevtmgt_sessiontrack.md)|msevtmgt_sessiontrack_AsyncOperations|
|regardingobjectid_msevtmgt_speaker|[msevtmgt_speaker EntityType](msevtmgt_speaker.md)|msevtmgt_speaker_AsyncOperations|
|regardingobjectid_msevtmgt_speakerengagement|[msevtmgt_speakerengagement EntityType](msevtmgt_speakerengagement.md)|msevtmgt_speakerengagement_AsyncOperations|
|regardingobjectid_msevtmgt_sponsorablearticle|[msevtmgt_sponsorablearticle EntityType](msevtmgt_sponsorablearticle.md)|msevtmgt_sponsorablearticle_AsyncOperations|
|regardingobjectid_msevtmgt_sponsorship|[msevtmgt_sponsorship EntityType](msevtmgt_sponsorship.md)|msevtmgt_sponsorship_AsyncOperations|
|regardingobjectid_msevtmgt_venue|[msevtmgt_venue EntityType](msevtmgt_venue.md)|msevtmgt_venue_AsyncOperations|
|regardingobjectid_msevtmgt_webinarconfiguration|[msevtmgt_webinarconfiguration EntityType](msevtmgt_webinarconfiguration.md)|msevtmgt_webinarconfiguration_AsyncOperations|
|regardingobjectid_msevtmgt_webinarconsent|[msevtmgt_webinarconsent EntityType](msevtmgt_webinarconsent.md)|msevtmgt_webinarconsent_AsyncOperations|
|regardingobjectid_msevtmgt_webinarprovider|[msevtmgt_webinarprovider EntityType](msevtmgt_webinarprovider.md)|msevtmgt_webinarprovider_AsyncOperations|
|regardingobjectid_msevtmgt_webinartype|[msevtmgt_webinartype EntityType](msevtmgt_webinartype.md)|msevtmgt_webinartype_AsyncOperations|
|regardingobjectid_new_interactionforemail|[interactionforemail EntityType](interactionforemail.md)|new_interactionforemail_AsyncOperations|
|regardingobjectid_opportunity|[opportunity EntityType](opportunity.md)|Opportunity_AsyncOperations|
|regardingobjectid_opportunityclose|[opportunityclose EntityType](opportunityclose.md)|OpportunityClose_AsyncOperations|
|regardingobjectid_opportunitycompetitors|[opportunitycompetitors EntityType](opportunitycompetitors.md)|opportunitycompetitors_AsyncOperations|
|regardingobjectid_opportunityproduct|[opportunityproduct EntityType](opportunityproduct.md)|OpportunityProduct_AsyncOperations|
|regardingobjectid_opportunitysalesprocess|[opportunitysalesprocess EntityType](opportunitysalesprocess.md)|opportunitysalesprocess_AsyncOperations|
|regardingobjectid_orderclose|[orderclose EntityType](orderclose.md)|OrderClose_AsyncOperations|
|regardingobjectid_organization|[organization EntityType](organization.md)|Organization_AsyncOperations|
|regardingobjectid_phonecall|[phonecall EntityType](phonecall.md)|PhoneCall_AsyncOperations|
|regardingobjectid_phonetocaseprocess|[phonetocaseprocess EntityType](phonetocaseprocess.md)|phonetocaseprocess_AsyncOperations|
|regardingobjectid_position|[position EntityType](position.md)|position_AsyncOperations|
|regardingobjectid_post|[post EntityType](post.md)|post_AsyncOperations|
|regardingobjectid_postfollow|[postfollow EntityType](postfollow.md)|PostFollow_AsyncOperations|
|regardingobjectid_pricelevel|[pricelevel EntityType](pricelevel.md)|PriceLevel_AsyncOperations|
|regardingobjectid_privilege|[privilege EntityType](privilege.md)|Privilege_AsyncOperations|
|regardingobjectid_product|[product EntityType](product.md)|Product_AsyncOperations|
|regardingobjectid_productassociation|[productassociation EntityType](productassociation.md)|ProductAssociation_AsyncOperations|
|regardingobjectid_productpricelevel|[productpricelevel EntityType](productpricelevel.md)|ProductPriceLevel_AsyncOperations|
|regardingobjectid_productsalesliterature|[productsalesliterature EntityType](productsalesliterature.md)|productsalesliterature_AsyncOperations|
|regardingobjectid_productsubstitute|[productsubstitute EntityType](productsubstitute.md)|ProductSubstitute_AsyncOperations|
|regardingobjectid_quarterlyfiscalcalendar|[quarterlyfiscalcalendar EntityType](quarterlyfiscalcalendar.md)|QuarterlyFiscalCalendar_AsyncOperations|
|regardingobjectid_queue|[queue EntityType](queue.md)|Queue_AsyncOperations|
|regardingobjectid_queueitem|[queueitem EntityType](queueitem.md)|QueueItem_AsyncOperations|
|regardingobjectid_quote|[quote EntityType](quote.md)|Quote_AsyncOperations|
|regardingobjectid_quoteclose|[quoteclose EntityType](quoteclose.md)|QuoteClose_AsyncOperations|
|regardingobjectid_quotedetail|[quotedetail EntityType](quotedetail.md)|QuoteDetail_AsyncOperations|
|regardingobjectid_ratingmodel|[ratingmodel EntityType](ratingmodel.md)|ratingmodel_AsyncOperations|
|regardingobjectid_ratingvalue|[ratingvalue EntityType](ratingvalue.md)|ratingvalue_AsyncOperations|
|regardingobjectid_recurringappointmentmaster|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|RecurringAppointmentMaster_AsyncOperations|
|regardingobjectid_report|[report EntityType](report.md)|Report_AsyncOperations|
|regardingobjectid_resource|[resource EntityType](resource.md)|Resource_AsyncOperations|
|regardingobjectid_resourcegroup|[resourcegroup EntityType](resourcegroup.md)|ResourceGroup_AsyncOperations|
|regardingobjectid_resourcespec|[resourcespec EntityType](resourcespec.md)|ResourceSpec_AsyncOperations|
|regardingobjectid_role|[role EntityType](role.md)|Role_AsyncOperations|
|regardingobjectid_salesliterature|[salesliterature EntityType](salesliterature.md)|SalesLiterature_AsyncOperations|
|regardingobjectid_salesliteratureitem|[salesliteratureitem EntityType](salesliteratureitem.md)|SalesLiteratureItem_AsyncOperations|
|regardingobjectid_salesorder|[salesorder EntityType](salesorder.md)|SalesOrder_AsyncOperations|
|regardingobjectid_salesorderdetail|[salesorderdetail EntityType](salesorderdetail.md)|SalesOrderDetail_AsyncOperations|
|regardingobjectid_savedquery|[savedquery EntityType](savedquery.md)|SavedQuery_AsyncOperations|
|regardingobjectid_semiannualfiscalcalendar|[semiannualfiscalcalendar EntityType](semiannualfiscalcalendar.md)|SemiAnnualFiscalCalendar_AsyncOperations|
|regardingobjectid_service|[service EntityType](service.md)|Service_AsyncOperations|
|regardingobjectid_serviceappointment|[serviceappointment EntityType](serviceappointment.md)|ServiceAppointment_AsyncOperations|
|regardingobjectid_sharepointdocumentlocation|[sharepointdocumentlocation EntityType](sharepointdocumentlocation.md)|SharePointDocumentLocation_AsyncOperations|
|regardingobjectid_sharepointsite|[sharepointsite EntityType](sharepointsite.md)|SharePointSite_AsyncOperations|
|regardingobjectid_similarityrule|[similarityrule EntityType](similarityrule.md)|similarityrule_AsyncOperations|
|regardingobjectid_site|[site EntityType](site.md)|Site_AsyncOperations|
|regardingobjectid_sla|[sla EntityType](sla.md)|slabase_AsyncOperations|
|regardingobjectid_socialactivity|[socialactivity EntityType](socialactivity.md)|SocialActivity_AsyncOperations|
|regardingobjectid_socialprofile|[socialprofile EntityType](socialprofile.md)|SocialProfile_AsyncOperations|
|regardingobjectid_subject|[subject EntityType](subject.md)|Subject_AsyncOperations|
|regardingobjectid_systemform|[systemform EntityType](systemform.md)|SystemForm_AsyncOperations|
|regardingobjectid_systemuser|[systemuser EntityType](systemuser.md)|SystemUser_AsyncOperations|
|regardingobjectid_task|[task EntityType](task.md)|Task_AsyncOperations|
|regardingobjectid_team|[team EntityType](team.md)|Team_AsyncOperations|
|regardingobjectid_template|[template EntityType](template.md)|Template_AsyncOperations|
|regardingobjectid_territory|[territory EntityType](territory.md)|Territory_AsyncOperations|
|regardingobjectid_theme|[theme EntityType](theme.md)|theme_AsyncOperations|
|regardingobjectid_transactioncurrency|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_AsyncOperations|
|regardingobjectid_uom|[uom EntityType](uom.md)|UoM_AsyncOperations|
|regardingobjectid_uomschedule|[uomschedule EntityType](uomschedule.md)|UoMSchedule_AsyncOperations|
|regardingobjectid_userform|[userform EntityType](userform.md)|UserForm_AsyncOperations|
|regardingobjectid_userquery|[userquery EntityType](userquery.md)|UserQuery_AsyncOperations|
|workflowactivationid|[workflow EntityType](workflow.md)|lk_asyncoperation_workflowactivationid|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|AsyncOperation_BulkDeleteOperation|[bulkdeleteoperation EntityType](bulkdeleteoperation.md)|asyncoperationid|  
|AsyncOperation_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|asyncoperationid|  
|AsyncOperation_Emails|[email EntityType](email.md)|regardingobjectid_asyncoperation|  
|AsyncOperation_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_asyncoperation|  
|lk_workflowlog_asyncoperation_childworkflow|[workflowlog EntityType](workflowlog.md)|childworkflowinstanceid_asyncoperation|  
|lk_workflowlog_asyncoperations|[workflowlog EntityType](workflowlog.md)|asyncoperationid_asyncoperation|  

## Operations
The following operations can be used with the asyncoperation entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|    

[!INCLUDE[./remarks/asyncoperation.md](./remarks/asyncoperation.md)]

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