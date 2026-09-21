---
title: "SLA table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the SLA table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: puneet-singh1
ms.author: puneetsingh
search.audienceType: 
  - developer
---

# SLA table/entity reference (Microsoft Dynamics 365 Field Service)

Contains information about the tracked service-level KPIs for cases that belong to different customers.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service SLA table extends the [Microsoft Dynamics 365 SLA table](/dynamics365/developer/reference/entities/sla).



## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_ObjectTypeCode"></a> ObjectTypeCode

Changes from [ObjectTypeCode (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/sla#BKMK_ObjectTypeCode)

#### ObjectTypeCode Choices/Options

|Value|Label|
|---|---|
|1083|**Opportunity Line**|
|1085|**Quote Line**|
|1089|**Order Line**|
|10008|**Package**|
|10009|**Package History**|
|10011|**StageSolutionUpload**|
|10012|**ExportSolutionUpload**|
|10048|**App Notification Signal**|
|10049|**Shared Object**|
|10050|**Shared Workspace**|
|10051|**Shared Workspace Access Token**|
|10052|**Shared Workspace Pool**|
|10053|**Data Lake Folder**|
|10054|**Data Lake Folder Permission**|
|10055|**Data Lake Workspace**|
|10056|**Data Lake Workspace Permission**|
|10057|**Data Processing configuration**|
|10058|**Exported Excel**|
|10059|**RetainedData Excel**|
|10060|**Synapse Database**|
|10061|**Synapse Link External Table State**|
|10062|**Synapse Link Profile**|
|10063|**Synapse Link Profile Entity**|
|10064|**Synapse Link Profile Entity State**|
|10065|**Synapse Link Schedule**|
|10066|**Component Changeset Payload**|
|10067|**Component Changeset Version**|
|10068|**Component Version**|
|10069|**Component Version Data Source**|
|10070|**Component Version (Internal)**|
|10071|**DataflowRefreshHistory**|
|10072|**EntityRefreshHistory**|
|10073|**Shared Link Setting**|
|10074|**Any Privilege Entity**|
|10075|**DelegatedAuthorization**|
|10077|**CascadeGrantRevokeAccessRecordsTracker**|
|10078|**CascadeGrantRevokeAccessVersionTracker**|
|10080|**TdsMetadata**|
|10081|**Model-Driven App Element**|
|10082|**Model-Driven App Component Node's Edge**|
|10083|**Model-Driven App Component Node**|
|10084|**Model-Driven App Setting**|
|10085|**Model-Driven App User Setting**|
|10086|**Organization Setting**|
|10087|**Setting Definition**|
|10088|**CanvasApp Extended Metadata**|
|10089|**Service Plan Mapping**|
|10090|**Service Plan Custom Control**|
|10092|**ApplicationUser**|
|10095|**Git Branch**|
|10098|**Git Organization**|
|10099|**Git Project**|
|10100|**Git Repository**|
|10101|**Git Solution**|
|10102|**Source Control Branch Configuration**|
|10103|**Source Control Component**|
|10104|**Source Control Component Payload**|
|10105|**Source Control Configuration**|
|10106|**Source Control Operation Status**|
|10107|**Staged Source Control Component**|
|10108|**OData v4 Data Source**|
|10109|**Workflow Binary**|
|10110|**Business Process**|
|10111|**Credential**|
|10112|**Desktop Flow Module**|
|10113|**Flow Capacity Assignment**|
|10114|**Flow Credential Application**|
|10115|**Flow Event**|
|10116|**Flow Machine**|
|10117|**Flow Machine Group**|
|10118|**Flow Machine Image**|
|10119|**Flow Machine Image Version**|
|10120|**Flow Machine Network**|
|10121|**Flow Session Binary**|
|10122|**ProcessStageParameter**|
|10123|**Saving Rule**|
|10124|**Tag**|
|10125|**Tagged Flow Session**|
|10126|**Tagged Process**|
|10127|**Workflow Metadata**|
|10128|**Work Queue**|
|10129|**Work Queue Item**|
|10130|**Desktop Flow Binary**|
|10131|**Flow Aggregation**|
|10132|**Flow Log**|
|10133|**Flow Run**|
|10134|**Approval Process**|
|10135|**Approval Stage Approval**|
|10136|**Approval Stage Condition**|
|10137|**Approval Stage Intelligent**|
|10138|**Approval Stage Order**|
|10139|**Action Approval Model**|
|10140|**Approval**|
|10141|**Approval Request**|
|10142|**Approval Response**|
|10143|**Approval Step**|
|10144|**Await All Action Approval Model**|
|10145|**Await All Approval Model**|
|10146|**Basic Approval Model Data**|
|10147|**Flow Approval**|
|10156|**Connection Reference**|
|10165|**DVTableSearch**|
|10166|**DVTableSearchAttribute**|
|10167|**DVTableSearchEntity**|
|10168|**AICopilot**|
|10169|**AIPluginAuth**|
|10170|**AI Plugin Conversation Starter**|
|10171|**AI Plugin Conversation Starter Mapping**|
|10172|**AI Plugin Governance**|
|10173|**AI Plugin Governance Extended**|
|10174|**AIPluginOperationResponseTemplate**|
|10175|**AIPluginTitle**|
|10176|**SideloadedAIPlugin**|
|10177|**AIPlugin**|
|10178|**AIPluginExternalSchema**|
|10179|**AIPluginExternalSchemaProperty**|
|10180|**AIPluginInstance**|
|10181|**AIPluginOperation**|
|10182|**AIPluginOperationParameter**|
|10183|**AIPluginUserSetting**|
|10185|**AI Configuration Search**|
|10186|**Data Processing Event**|
|10187|**AI Document Template**|
|10188|**AI Event**|
|10189|**AI Model Catalog**|
|10191|**AI Builder Feedback Loop**|
|10192|**AI Form Processing Document**|
|10194|**AI Object Detection Label**|
|10195|**AI Object Detection Bounding Box**|
|10196|**AI Object Detection Image Mapping**|
|10198|**AI Builder Dataset**|
|10200|**AI Builder Dataset Record**|
|10201|**AI Builder Datasets Container**|
|10202|**AI Builder File**|
|10203|**AI Builder File Attached Data**|
|10204|**AI Evaluation Configuration**|
|10205|**AI Evaluation Metric**|
|10207|**AI Optimization**|
|10208|**AI Optimization Private Data**|
|10209|**AI Test Case**|
|10210|**AI Test Case Document**|
|10211|**AI Test Case Input**|
|10212|**AI Test Run**|
|10213|**AI Test Run Batch**|
|10214|**Help Page**|
|10215|**Tour**|
|10216|**BotContent**|
|10217|**ConversationTranscript**|
|10218|**Agent**|
|10219|**Agent component**|
|10220|**Agent component collection**|
|10240|**Data Movement Service Request Status**|
|10241|**DMS Sync Request**|
|10242|**DMS Sync Status**|
|10243|**Knowledge Asset Configuration**|
|10244|**Module Run Detail**|
|10245|**QnA**|
|10246|**Salesforce Structured Object**|
|10247|**Salesforce Structured QnA Config**|
|10248|**Workflow Action Status**|
|10249|**Allowed MCP Client**|
|10250|**FederatedKnowledgeCitation**|
|10251|**FederatedKnowledgeConfiguration**|
|10252|**FederatedKnowledgeEntityConfiguration**|
|10253|**FederatedKnowledgeMetadataRefresh**|
|10254|**IntelligentMemory**|
|10255|**Knowledge FAQ**|
|10256|**Form Mapping**|
|10257|**Copilot Interactions**|
|10258|**PDF Setting**|
|10259|**Activity File Attachment**|
|10260|**Teams chat**|
|10261|**Service Configuration**|
|10262|**SLA KPI**|
|10263|**Integrated search provider**|
|10264|**Knowledge Management Setting**|
|10265|**Knowledge Federated Article**|
|10266|**Knowledge Federated Article Incident**|
|10267|**Search provider**|
|10268|**Knowledge Article Image**|
|10269|**Knowledge Configuration**|
|10270|**Knowledge Interaction Insight**|
|10271|**Knowledge Search Insight**|
|10272|**Favorite knowledge article**|
|10273|**Knowledge article language setting**|
|10274|**Knowledge Article Attachment**|
|10275|**Knowledge personalization**|
|10276|**Knowledge Article Template**|
|10277|**Knowledge search personal filter config**|
|10278|**Knowledge search filter**|
|10280|**msdyn_historicalcaseharvestbatch**|
|10281|**msdyn_historicalcaseharvestrun**|
|10282|**Interim Update Knowledge Article**|
|10283|**Knowledge Article Custom Entity**|
|10284|**Knowledge Harvest Job Record**|
|10285|**SupportUserTable**|
|10286|**FxExpression**|
|10287|**Function**|
|10288|**Plug-in**|
|10289|**PowerfxRule**|
|10290|**Planner Business Scenario**|
|10291|**Planner Sync Action**|
|10292|**MCPPrompt**|
|10293|**MCPResource**|
|10294|**MCPResourceContent**|
|10295|**MCPServer**|
|10296|**MCPTool**|
|10297|**ToolingGateway**|
|10298|**ToolingGatewayMCPServer**|
|10299|**Email Address Configuration**|
|10300|**Ms Graph Resource To Subscription**|
|10301|**Virtual Entity  Metadata**|
|10302|**Background Operation**|
|10303|**Report Parameter**|
|10304|**MobileOfflineProfileExtension**|
|10305|**MobileOfflineProfileItemFilter**|
|10306|**TeamMobileOfflineProfileMembership**|
|10307|**UserMobileOfflineProfileMembership**|
|10308|**OrganizationDataSyncSubscription**|
|10309|**OrganizationDataSyncSubscriptionEntity**|
|10310|**OrganizationDataSyncSubscriptionFnoTable**|
|10311|**OrganizationDataSyncFnoState**|
|10312|**OrganizationDataSyncState**|
|10313|**ArchiveCleanupInfo**|
|10314|**ArchiveCleanupOperation**|
|10315|**BulkArchiveConfig**|
|10316|**BulkArchiveFailureDetail**|
|10317|**BulkArchiveOperation**|
|10318|**BulkArchiveOperationDetail**|
|10319|**EnableArchivalRequest**|
|10320|**MetadataForArchival**|
|10321|**ReconciliationEntityInfo**|
|10322|**ReconciliationEntityStepInfo**|
|10323|**ReconciliationInfo**|
|10324|**RetentionCleanupInfo**|
|10325|**RetentionCleanupOperation**|
|10326|**Data Life Cycle Config**|
|10327|**RetentionFailureDetail**|
|10328|**RetentionOperation**|
|10329|**RetentionOperationDetail**|
|10330|**RetentionSuccessDetail**|
|10331|**CertificateCredential**|
|10332|**Notification**|
|10333|**User Rating**|
|10334|**Mobile App**|
|10335|**Power Apps Wrap Build**|
|10336|**Insights Store Data Source**|
|10337|**Insights Store Virtual Entity**|
|10338|**RoleEditorLayout**|
|10339|**Deleted Record Reference**|
|10340|**Restore Deleted Records Configuration**|
|10341|**App Action**|
|10342|**App Action Migration**|
|10343|**App Action Rule**|
|10346|**Card**|
|10347|**Card State Item**|
|10350|**Entity link chat configuration**|
|10351|**Agent Feed Item**|
|10352|**Agent Hub Goal**|
|10353|**Agent Hub Insight**|
|10354|**Agent Hub Metric**|
|10355|**Agentic Scenario**|
|10356|**Agent Memory**|
|10357|**Agent Task**|
|10358|**SharePoint Managed Identity**|
|10359|**AI Insight Card**|
|10360|**AI Skill Config**|
|10361|**Suggested Action**|
|10362|**Suggested Action Criteria**|
|10363|**Data Workspace**|
|10364|**Plan**|
|10365|**Plan Artifact**|
|10366|**Plan Attachment**|
|10367|**UX Agent Component**|
|10368|**UX Agent Component Revision**|
|10369|**UX Agent Project**|
|10370|**UX Agent Project File**|
|10371|**Agent Conversation Message**|
|10372|**Agent Conversation Message File**|
|10373|**Rich Text Attachment**|
|10374|**Structured Template**|
|10375|**RTE Template Mapping**|
|10376|**Custom Control Extended Setting**|
|10377|**Timeline Pin**|
|10378|**Virtual Connector Data Source**|
|10379|**Virtual Table Column Candidate**|
|10381|**PM Analysis History**|
|10382|**PM Business Rule Automation Config**|
|10383|**PM Calendar**|
|10384|**PM Calendar Version**|
|10385|**PM Inferred Task**|
|10386|**PM Process Extended Metadata Version**|
|10387|**PM Process Template**|
|10388|**PM Process User Settings**|
|10389|**PM Process Version**|
|10390|**PM Recording**|
|10391|**PM Simulation**|
|10392|**PM Tab**|
|10393|**PM Template**|
|10394|**PM View**|
|10395|**Analysis Component**|
|10396|**Analysis Job**|
|10397|**Analysis Override**|
|10398|**Analysis Result**|
|10399|**Analysis Result Detail**|
|10400|**Solution Health Rule**|
|10401|**Solution Health Rule Argument**|
|10402|**Solution Health Rule Set**|
|10403|**Power BI Dataset**|
|10404|**powerbidatasetapdx**|
|10405|**Power BI Mashup Parameter**|
|10406|**Power BI Report**|
|10407|**powerbireportapdx**|
|10408|**File Upload**|
|10409|**AppEntitySearchView**|
|10410|**MainFewShot**|
|10411|**MakerFewShot**|
|10412|**SearchAttributeSettings**|
|10413|**SearchCustomAnalyzer**|
|10414|**SearchRelationshipSettings**|
|10415|**SearchResultsCache**|
|10416|**Search Telemetry**|
|10417|**TextDataRecordsIndexingStatus**|
|10418|**ViewAsExampleQuestion**|
|10419|**CopilotExampleQuestion**|
|10420|**CopilotGlossaryTerm**|
|10421|**CopilotSynonyms**|
|10422|**Business Skill**|
|10423|**Site Component**|
|10424|**Site**|
|10425|**Site Language**|
|10426|**Power Pages Site Published**|
|10427|**Site Source File**|
|10430|**External Identity**|
|10431|**Invitation**|
|10432|**Invite Redemption**|
|10433|**Portal Comment**|
|10434|**Setting**|
|10435|**Multistep Form Session**|
|10439|**Ad Placement**|
|10440|**Column Permission**|
|10441|**Column Permission Profile**|
|10442|**Content Snippet**|
|10443|**Basic Form**|
|10444|**Basic Form Metadata**|
|10445|**List**|
|10446|**Table Permission**|
|10447|**Page Template**|
|10448|**Poll Placement**|
|10449|**Power Pages Core Entity DS**|
|10450|**Publishing State**|
|10451|**Publishing State Transition Rule**|
|10452|**Redirect**|
|10453|**Shortcut**|
|10454|**Site Marker**|
|10455|**Site Setting**|
|10456|**Web File**|
|10457|**Multistep Form**|
|10458|**Multistep Form Metadata**|
|10459|**Form Step**|
|10460|**Web Link**|
|10461|**Web Link Set**|
|10462|**Web Page**|
|10463|**Web Page Access Control Rule**|
|10464|**Web Role**|
|10465|**Website**|
|10466|**Website Access**|
|10467|**Website Language**|
|10468|**Web Template**|
|10475|**Power Pages Scan Report**|
|10476|**PowerPagesDDOSAlert**|
|10477|**Power Pages Log**|
|10478|**PowerPagesManagedIdentity**|
|10479|**Power Pages Site AI Feedback**|
|10485|**Catalog Submission Files**|
|10486|**Package Submission Store**|
|10487|**indexedtrait**|
|10488|**processor registration**|
|10489|**signal**|
|10490|**signal registration**|
|10491|**trait**|
|10492|**trait registration**|
|10493|**List Operation**|
|10494|**Marketing Form Display Attributes**|
|10495|**Database Version**|
|10496|**Upgrade Run**|
|10497|**Upgrade Step**|
|10498|**Upgrade Version**|
|10499|**Activity monitor**|
|10500|**Originating Queue Mapping**|
|10502|**Unified Routing Setup Tracker**|
|10503|**Available Times**|
|10504|**Available Times Data Source**|
|10505|**resource group data source**|
|10506|**Virtual Resource Group Resource**|
|10507|**Migration tracker**|
|10508|**Asset Category Template Association**|
|10509|**Asset Template Association**|
|10510|**Customer Asset**|
|10513|**Customer Asset Attachment**|
|10514|**Customer Asset Category**|
|10515|**Functional Location**|
|10516|**Functional Location Type**|
|10517|**Location Template Association**|
|10518|**Functional Location Type Template Association**|
|10519|**Property Definition**|
|10520|**Property Asset Association**|
|10521|**Property Location Association**|
|10522|**Property Log**|
|10523|**Property Template Association**|
|10524|**Template For Properties**|
|10525|**Warranty**|
|10532|**IoT Alert**|
|10533|**IoT Device**|
|10534|**IoT Device Category**|
|10535|**IoT Device Command**|
|10536|**IoT Device Command Definition**|
|10537|**IoT Device Data History**|
|10538|**IoT Device Property**|
|10539|**IoT Device Registration History**|
|10540|**IoT Device Visualization Configuration**|
|10541|**IoT Field Mapping**|
|10542|**IoT Property Definition**|
|10543|**IoT Provider**|
|10544|**IoT Provider Instance**|
|10545|**IoT Settings**|
|10548|**IoT Alert to Case Process**|
|10550|**Playbook Callable Context**|
|10551|**Playbook activity**|
|10552|**Playbook activity attribute**|
|10553|**[DEPRECATED] Playbook category**|
|10554|**Playbook**|
|10555|**[DEPRECATED] Playbook template**|
|10557|**admin_settings_entity**|
|10558|**Collab Space Team Association**|
|10559|**CRM Activity Mapping**|
|10560|**CRM Connection**|
|10561|**Derived insights related entity**|
|10562|**Entity derived insights**|
|10563|**External CRM**|
|10564|**External Record**|
|10565|**Lead Intelligence Insight**|
|10566|**Lead Intelligence Insight Entity Link**|
|10567|**msdyn_rawinsight**|
|10568|**msdyn_rawinsightentitylink**|
|10569|**Tagged Record**|
|10570|**M365 Copilot Sales customer list**|
|10571|**msdyn_vivaentitysetting**|
|10572|**msdyn_vivaorgextensioncred**|
|10573|**msdyn_vivaorgsetting**|
|10574|**msdyn_vivausersetting**|
|10575|**Activity Mapping**|
|10576|**Sales Copilot Email Insight**|
|10577|**Sales Copilot Insight**|
|10578|**Sales Copilot Insight Card State**|
|10579|**Sales Copilot Job Status**|
|10580|**Sales Copilot Knowledge Base**|
|10581|**Org level settings for Sales Copilot apps**|
|10582|**Sales Copilot User Setting**|
|10583|**App profile**|
|10584|**Application Extension**|
|10585|**Application Tab Template**|
|10586|**App profile role mapping**|
|10587|**Notification Field**|
|10588|**Notification Template**|
|10589|**Session Template**|
|10590|**Template Parameter**|
|10596|**Channel Integration Framework v1.0 Provider**|
|10597|**Notification Field (Deprecated)**|
|10598|**Notification Template (Deprecated)**|
|10599|**App Parameter Definition (Deprecated)**|
|10600|**Session Templates (Deprecated)**|
|10601|**Application Tab Template (Deprecated)**|
|10602|**Parameter (Deprecated)**|
|10603|**Template Tag (Deprecated)**|
|10604|**Application Type (Deprecated)**|
|10613|**Channel Integration Framework v2.0 Provider**|
|10615|**Conversation Data (Deprecated)**|
|10616|**KPI Event Data**|
|10617|**KPI Event Definition**|
|10618|**Session Data (Deprecated)**|
|10619|**Session Participant Data (Deprecated)**|
|10620|**Channel Definition**|
|10621|**Channel Definition Consent**|
|10622|**Channel Definition Locale**|
|10623|**Channel Instance**|
|10624|**Channel Instance Account**|
|10625|**Channel Message Attachment**|
|10626|**Channel Message Context Part**|
|10627|**Channel Message Part**|
|10628|**Consuming Application**|
|10629|**msdyn_DefExtendedChannelInstance**|
|10630|**msdyn_DefExtendedChannelInstanceAccount**|
|10631|**Productivity pane configuration**|
|10632|**Pane tab configuration**|
|10633|**Pane tool configuration**|
|10635|**Script**|
|10636|**Script step**|
|10638|**Action Input Parameter**|
|10639|**Action Output Parameter**|
|10640|**Macro Action Template**|
|10641|**Macro Solution Configuration**|
|10642|**Macro Connector**|
|10643|**Macro Run History**|
|10644|**Parameter definition**|
|10647|**Adaptive Card Configuration**|
|10648|**Smartassist configuration**|
|10650|**Read Tracker**|
|10651|**Read tracking enabled information**|
|10652|**Microsoft Teams Graph resource Entity**|
|10653|**msdyn_msteamssetting**|
|10654|**msdyn_msteamssettingsv2**|
|10655|**Microsoft Teams Collaboration entity**|
|10656|**Teams Dialer Admin settings**|
|10657|**Teams Contact Suggestion by AI**|
|10658|**Contact suggestion rule**|
|10659|**Contact suggestion ruleset**|
|10660|**Microsoft Teams chat association entity**|
|10661|**Microsoft Teams chat suggestion**|
|10662|**Hierarchy Configuration**|
|10663|**Microsoft Orgchart node entity**|
|10664|**Forecast Manual Adjustment History**|
|10665|**Distributed Lock**|
|10666|**Entity Delta Change**|
|10667|**File Upload Status Tracker**|
|10668|**Forecast**|
|10669|**Forecast Configuration**|
|10670|**Forecast definition**|
|10671|**Forecasting Cache**|
|10672|**Forecast Insights**|
|10673|**Forecast**|
|10674|**Forecast Prediction Data**|
|10675|**Forecast Prediction Status**|
|10676|**Forecast recurrence**|
|10677|**Recompute Tracker**|
|10678|**Forecast Recurrence**|
|10679|**ShareAs Configuration**|
|10680|**Customer email communication**|
|10681|**GDPRData**|
|10682|**ODOSFeatureMetadata**|
|10683|**ODOSMetadata**|
|10684|**Recurring Sales Action**|
|10685|**Recurring Sales Action V2**|
|10686|**msdyn_relationshipinsightsunifiedconfig**|
|10687|**siconfig**|
|10688|**SI Key Value Config**|
|10689|**Usage Metric**|
|10690|**Action Card Regarding**|
|10691|**Action Card Role Setting**|
|10692|**EntityRankingRule**|
|10693|**flowcardtype**|
|10694|**salesinsightssettings**|
|10695|**Action Card Usage**|
|10696|**Action Card Usage Aggregation**|
|10697|**Auto Capture Rule**|
|10698|**Auto Capture Settings**|
|10699|**UntrackedAppointment**|
|10700|**Suggested Activity**|
|10701|**Suggested Activity Data Source**|
|10702|**Suggested Contact**|
|10703|**Suggested Contacts Data Source**|
|10704|**Notes analysis Config**|
|10705|**icebreakersconfig**|
|10706|**dealmanageraccess**|
|10707|**Deal manager settings**|
|10708|**Account KPI Item**|
|10709|**Activity Analysis CleanUp State**|
|10710|**Relationship Analytics Config**|
|10711|**Contact KPI Item**|
|10712|**Daily Kpis for account**|
|10713|**Daily kpis for contact**|
|10714|**Daily kpis for lead**|
|10715|**Daily kpis for Opportunity**|
|10716|**Lead KPI Item**|
|10717|**Most Contacted**|
|10718|**Most Contacted By**|
|10719|**Opportunity KPI Item**|
|10720|**Relationship Analytics Metadata**|
|10721|**Similar entities feature importance**|
|10722|**wkwcolleaguesforcompany**|
|10723|**wkwcolleaguesforcontact**|
|10724|**wkwconfig**|
|10725|**Attribute Influence Statistics**|
|10726|**Prediction Computation Operation**|
|10727|**Prediction Model Status**|
|10728|**Prediction Scheduled Operation**|
|10729|**Predictive Model Score**|
|10730|**Predictive Score**|
|10731|**Predictive Scoring Sync Status**|
|10732|**Real Time Scoring**|
|10733|**Real Time Scoring Operation**|
|10734|**Submodel Definition**|
|10735|**Time spent in BPF**|
|10736|**Training Result**|
|10737|**OpportunityModelConfig**|
|10738|**LeadModelConfig**|
|10739|**ModelPreviewStatus**|
|10740|**Profile Album**|
|10741|**Post Configuration**|
|10742|**Post Rule Configuration**|
|10743|**Wall View**|
|10744|**Filter**|
|10745|**Customer Voice alert**|
|10746|**Customer Voice alert rule**|
|10747|**Customer Voice user activity**|
|10748|**Customer Voice survey email template**|
|10749|**Customer Voice file response**|
|10750|**Customer Voice localized survey email template**|
|10751|**Customer Voice Log**|
|10752|**Customer Voice project**|
|10753|**Customer Voice survey question**|
|10754|**Customer Voice survey question response**|
|10755|**Customer Voice satisfaction metric**|
|10756|**Customer Voice Satisfaction Metric Aggregate**|
|10757|**Customer Voice Satisfaction Metric Survey Mapping**|
|10758|**Shorturl**|
|10759|**Customer Voice survey**|
|10760|**Customer Voice survey invite**|
|10761|**Customer Voice survey invite summary**|
|10762|**Customer Voice survey reminder**|
|10763|**Customer Voice survey response**|
|10764|**Customer Voice unsubscribed recipient**|
|10765|**Customer Service Key Value Configuration**|
|10766|**AddToCalendar style**|
|10767|**basestyle**|
|10768|**Button style**|
|10769|**Code style**|
|10770|**Column style**|
|10771|**Content Block**|
|10772|**Divider style**|
|10773|**General styles**|
|10774|**imagestyle**|
|10775|**Layout Style**|
|10776|**QR code style**|
|10777|**Text style**|
|10778|**Video style**|
|10779|**App state**|
|10780|**CSAdminConfig**|
|10781|**Product Map**|
|10782|**Custom API Ruleset Configuration**|
|10783|**Decision contract**|
|10784|**Decision rule set**|
|10785|**Rulesetentitymapping**|
|10786|**Routing diagnostic item**|
|10787|**Routing diagnostic**|
|10788|**Template Context Variable**|
|10789|**Template Rule Set**|
|10790|**Template Variable Batch Operation**|
|10792|**Inbox card configuration**|
|10793|**Inbox Configuration**|
|10794|**Inbox Entity Configuration**|
|10795|**Inbox Personalized Configuration**|
|10796|**App Profile Copilot Configuration**|
|10797|**Swarm**|
|10798|**Swarm participant**|
|10799|**Swarm participant rule**|
|10800|**Swarm role**|
|10801|**Swarm skill**|
|10802|**Swarm template**|
|10803|**Autonomous case creation and update rules**|
|10804|**CHT App Profile Configuration**|
|10805|**Entity Attachment**|
|10806|**Time Tracker**|
|10807|**Customer feedback survey**|
|10808|**Customer feedback survey invite**|
|10809|**Customer feedback survey response**|
|10810|**msdyn_surveyconfig**|
|10811|**Survey setting**|
|10812|**Entity Attribute Prediction Rule**|
|10813|**emailclassificationcategory**|
|10814|**emailclassificationcategoryversion**|
|10815|**Email Sentiment**|
|10816|**Agent Configuration**|
|10817|**Autonomous Agent Entity Mapping**|
|10818|**Autonomous Profile**|
|10819|**Rollout Plan**|
|10820|**Master Entity Routing Configuration**|
|10821|**Routing Rule Set Setting**|
|10822|**Assignment Configuration**|
|10823|**Assignment Configuration Step**|
|10824|**Capacity Profile**|
|10825|**msdyn_globalrulesetconfiguration**|
|10826|**Last Agent**|
|10827|**Overflow Action Config**|
|10828|**Preferred Agent**|
|10829|**Preferred Agent Customer Identity**|
|10830|**Preferred Agent Routed Entity**|
|10831|**Routing configuration**|
|10832|**Routing configuration step**|
|10833|**Custom messaging account**|
|10834|**Channel Configuration**|
|10835|**Channel State Configuration**|
|10836|**Provisioning State**|
|10837|**AdminAppState**|
|10838|**Agent Status history**|
|10839|**Power BI Configuration**|
|10840|**Authentication Settings**|
|10841|**Auth Settings Entry**|
|10842|**Quick reply**|
|10843|**Entity Routing Context**|
|10844|**Channel Capability**|
|10845|**Conversation Action**|
|10846|**Conversation Action Locale**|
|10847|**Conversation Message Block**|
|10848|**DeletedConversation**|
|10849|**Deprecated Workstream Entity Configuration**|
|10850|**Entity**|
|10851|**Ongoing conversation (Deprecated)**|
|10852|**Live work item event**|
|10853|**Work Stream**|
|10854|**Masking Rule**|
|10855|**Auto block rule**|
|10856|**Bot Channel Registration Secret**|
|10857|**Omnichannel channel api conversation privilege**|
|10858|**Omnichannel channel api message privilege**|
|10859|**Channel api method mapping**|
|10860|**External context**|
|10861|**Flagged spam**|
|10862|**Language**|
|10863|**Conversation**|
|10866|**Context item value**|
|10867|**Live Work Item Participant (Deprecated)**|
|10868|**Conversation Sentiment**|
|10869|**Context variable**|
|10870|**Localization**|
|10871|**OC Payment Profile**|
|10872|**Recording**|
|10873|**Omnichannel Request**|
|10874|**Rich message**|
|10875|**Rich object map**|
|10876|**Rule Item**|
|10877|**Sentiment daily topic**|
|10878|**Sentiment daily topic keyword**|
|10879|**Sentiment daily topic trending**|
|10880|**Session**|
|10881|**Session Participant Event**|
|10882|**Session Sentiment**|
|10883|**Automated Message**|
|10884|**Tag**|
|10885|**Geo Location Provider**|
|10886|**Omnichannel Configuration**|
|10887|**Omnichannel Personalization**|
|10888|**Omnichannel Queue (Deprecated)**|
|10889|**Omnichannel Sync Config**|
|10890|**Operating Hour**|
|10891|**Personal quick reply**|
|10892|**Personal sound setting**|
|10893|**Persona Security Role Mapping**|
|10894|**Presence**|
|10895|**Provider**|
|10896|**RoutingRequest**|
|10897|**Search Configuration**|
|10898|**Sentiment analysis**|
|10899|**Session event**|
|10900|**Session participant**|
|10901|**Audio File**|
|10902|**Sound notification setting**|
|10903|**Transcript**|
|10904|**UR notification template**|
|10905|**UR Notification Template Mapping**|
|10906|**User settings**|
|10907|**Self service**|
|10914|**Agent capacity update history**|
|10915|**Bookable Resource Capacity Profile**|
|10916|**Contact Center Generated Rule**|
|10917|**Work stream capacity profile**|
|10918|**Conversation Capacity profile**|
|10919|**Agent Capacity Profile Unit**|
|10920|**Agent Channel State**|
|10921|**Agent Status**|
|10922|**Agent Group**|
|10923|**Agent Group Language**|
|10924|**Agent Group Matching Criteria**|
|10925|**Agent Group Membership**|
|10926|**Agent Group Region**|
|10927|**Agent Language**|
|10928|**Agent Matching Criteria**|
|10929|**Agent Region**|
|10930|**Language Hierarchy**|
|10931|**Matching Criteria**|
|10932|**Conversation Matching Criteria**|
|10933|**Region**|
|10934|**Conversation Characteristic**|
|10935|**Session Characteristic**|
|10936|**Skill Attachment Rule**|
|10937|**Attach Skill**|
|10938|**Model training details**|
|10939|**Training data import configuration**|
|10940|**Characteristic mapping**|
|10941|**Training record**|
|10942|**Skill finder model**|
|10943|**Effort estimate**|
|10944|**Effort estimation model**|
|10945|**Effort model training details**|
|10946|**ConversationInsight**|
|10947|**Active ICD Extension**|
|10948|**Entity-Workstream Map**|
|10949|**ICD Extension**|
|10950|**msdyn_broadcastmessagebulkactionapiprivilege**|
|10951|**msdyn_bulkassigntoqueueapiprivilege**|
|10952|**msdyn_bulkforcecloseapiprivilege**|
|10953|**Lock Status**|
|10954|**msdyn_notifyagentbulkactionapiprivilege**|
|10955|**Omnichannel agent assignment custom api privilege**|
|10956|**Bulk Action**|
|10957|**Conversation Action Item**|
|10958|**Conversation Aggregated Insights**|
|10959|**Comment**|
|10960|**Conversation Participant Insights**|
|10961|**Conversation Participant Sentiment**|
|10962|**Conversation Question**|
|10963|**Conversation Segment Sentiment**|
|10964|**Conversation Sentiment**|
|10965|**Conversation Signal**|
|10966|**Conversation Subject**|
|10967|**Conversation Summary Suggestion**|
|10968|**Conversation System Tag**|
|10969|**Conversation Tag**|
|10970|**Recording (Deprecated)**|
|10971|**SCI Conversation**|
|10972|**Custom Email Highlight**|
|10973|**Custom Highlight**|
|10974|**Custom Publisher**|
|10975|**EnvironmentSettings**|
|10976|**UserSettings**|
|10977|**Digital assets configuration**|
|10978|**File**|
|10979|**Tag**|
|10980|**Video**|
|10983|**CatalogEventStatusConfiguration**|
|10984|**Configuration**|
|10985|**Trigger**|
|10986|**Triggers To Sdk Message Processing Steps**|
|10987|**EventParameterMetadata**|
|10988|**TrackingContext**|
|10989|**Marketing feature configuration**|
|10990|**Consent Provider**|
|10991|**Consent provider Localization**|
|10992|**(Deprecated) Compliance**|
|10993|**(Deprecated) Compliance**|
|10994|**Compliance profile**|
|10995|**Consent**|
|10996|**CXP Consent Center Configuration**|
|10997|**Consent Provider Default Configuration**|
|10998|**Default purpose**|
|10999|**Submit Button**|
|11000|**Consent System Configuration**|
|11001|**(Deprecated) Contact Point Consent**|
|11002|**(Deprecated) Contact Point Consent**|
|11003|**(Deprecated) Contact Point Consent**|
|11004|**Contact Point Consent**|
|11005|**Contact Point Settings**|
|11006|**CXP Customer Data Mapping**|
|11007|**Customer Data Selection**|
|11008|**Preference Center**|
|11009|**Preference center link**|
|11010|**Purpose**|
|11011|**Topic**|
|11013|**msdynmkt_experimentv2**|
|11014|**ACS channel instance**|
|11015|**ACS channel instance account**|
|11016|**Infobip channel instance**|
|11017|**Infobip channel instance account**|
|11018|**Link mobility channel instance**|
|11019|**Link mobility channel instance account**|
|11020|**MockSmsProvider channel instance**|
|11021|**MockSmsProvider channel instance account**|
|11022|**TeleSign channel instance**|
|11023|**TeleSign channel instance account**|
|11024|**Twilio channel instance**|
|11025|**Twilio channel instance account**|
|11026|**Vibes channel instance**|
|11027|**Vibes channel instance account**|
|11028|**Predefined Placeholder**|
|11029|**Metadata Entity Relationship**|
|11030|**Metadata Item**|
|11031|**Metadata Store State**|
|11032|**DigitalSellingActiveTask**|
|11033|**DigitalSellingCompletedTask**|
|11034|**Sales Tag**|
|11035|**Sequence**|
|11036|**Sequence Stat**|
|11037|**Sequence Target**|
|11038|**Sequence Target Step**|
|11039|**Sequence Template**|
|11041|**sabackupdiagnostic**|
|11042|**SABatchRunInstance**|
|11043|**salesroutingdiagnostic**|
|11044|**SARunInstance**|
|11045|**Segment**|
|11046|**segmentsetting**|
|11047|**Segment property**|
|11048|**SegmentsUtil**|
|11049|**Assignment Rule**|
|11050|**Seller attribute**|
|11051|**Seller attribute value**|
|11052|**Assignment Map**|
|11053|**Sales Assignment Setting**|
|11054|**Sales routing run**|
|11056|**Extended User Setting**|
|11057|**Sales acceleration insights**|
|11058|**Sales Acceleration settings**|
|11059|**Insight**|
|11060|**Work List Suggestion**|
|11061|**Work list suggestion source**|
|11062|**Work List View Configuration**|
|11063|**Work Queue Record**|
|11064|**Work Queue Record State**|
|11065|**Work list user setting**|
|11066|**WQDataSource**|
|11067|**Suggestion Assignment Rule**|
|11068|**Suggestion Principal Object Access**|
|11069|**Suggestion Seller Priority**|
|11070|**Data Hygiene Setting Info**|
|11071|**Duplicate Detection Plugin Run**|
|11072|**Duplicate Lead Mapping**|
|11073|**Lead Hygiene Setting**|
|11074|**Linked Entity Attribute Validity**|
|11075|**Sales provisioning request**|
|11076|**SalesOmnichannel Message**|
|11077|**Text message template**|
|11078|**Data Analytics Admin Settings (Deprecated)**|
|11079|**Data Analytics Report**|
|11080|**Insights**|
|11081|**Sales acceleration reports**|
|11082|**Bot user mapping**|
|11084|**Bot Session**|
|11085|**Context Item Elastic**|
|11086|**Queue Extension**|
|11087|**Timeout Rule**|
|11088|**Automated action rules mapping**|
|11089|**Capacity Wrap Up Time**|
|11090|**Channel Profile**|
|11091|**Channel Profile Notification Template**|
|11092|**Channel Profile Survey Config**|
|11095|**Conversation Record**|
|11096|**Last message info**|
|11097|**Encrypted message setting**|
|11098|**Message masking rule**|
|11099|**Agent Nudge**|
|11100|**Agent Nudge Template**|
|11101|**Compliance Rule**|
|11102|**msdyn_admin_pin**|
|11103|**Conversation disposition code map**|
|11104|**Disposition Code Category**|
|11105|**Live Conversation Counter Condition**|
|11106|**OC Disposition Code**|
|11107|**msdyn_personal_pin**|
|11108|**Work Stream Bot Mapping**|
|11110|**Representative Copilot Setting**|
|11111|**Agent Copilot Term**|
|11114|**copilot scenario setting**|
|11115|**Copilot Skill**|
|11116|**Copilot Skill Role**|
|11117|**Copilot Starter Prompt**|
|11118|**Copilot Summarization Setting**|
|11119|**Entity Copilot Configuration**|
|11120|**Organization Prompt**|
|11121|**msdyn_agentsetting**|
|11122|**msdyn_aiconnectormapping**|
|11123|**msdyn_businessprofile**|
|11124|**intent**|
|11125|**intentattribute**|
|11126|**intentattributeset**|
|11127|**intentattribute_entity**|
|11128|**Intent Config**|
|11129|**Intent Context History**|
|11130|**intententity**|
|11131|**LOB Backfill Status**|
|11132|**Line of Business**|
|11133|**Intent Family Admin Assignment**|
|11134|**msdyn_intentfamily_harvestingconfiguration**|
|11135|**msdyn_intentfeature_configuration**|
|11136|**Intent Group Condition**|
|11137|**msdyn_intentharvesting_batchjobstatus**|
|11138|**msdyn_intentharvesting_batchjobstatusdetail**|
|11139|**Intent Harvesting Proposed Intent**|
|11140|**msdyn_intentharvesting_provisioning_status**|
|11141|**msdyn_intentmetrics**|
|11142|**msdyn_intentmetrics_aggregate**|
|11143|**msdyn_intentmetrics_jobdata**|
|11144|**Intent Playbook**|
|11145|**Intent playbook map**|
|11146|**Intent Solution Map**|
|11147|**msdyn_intentsolution_mappingconfiguration**|
|11148|**msdyn_organizationsolutionmap**|
|11149|**Case Enrichment**|
|11150|**Case follow up and closure configuration**|
|11151|**Case sentiment settings**|
|11152|**Case Suggestion**|
|11153|**Case Suggestion Request Payload**|
|11154|**Case Suggestions Data Souce**|
|11155|**User Preference For Copilot**|
|11156|**Copilot assisted case form fill settings**|
|11157|**Copilot Event**|
|11158|**Copilot Interaction**|
|11159|**Copilot Interaction Data**|
|11160|**Copilot knowledge interaction**|
|11161|**Copilot Transcript**|
|11162|**Copilot Transcript Data**|
|11163|**KB Enrichment**|
|11164|**Knowledge Article Suggestion**|
|11165|**Knowledge Article Suggestion Data Source**|
|11166|**Next Action**|
|11167|**Service Copilot Plugin**|
|11168|**Service Copilot Plugin Action**|
|11169|**Service Copilot Plugin Role**|
|11170|**Suggestion Interaction**|
|11171|**Suggestion request payload**|
|11172|**Suggestions Model Summary**|
|11173|**Suggestions Setting**|
|11174|**AI Simulation Result**|
|11175|**AI Simulation Run**|
|11176|**msdyn_caseaiprediction**|
|11177|**Data Analytics User Customized Report**|
|11178|**Data Analytics Dataset**|
|11179|**Data Analytics Workspace**|
|11180|**Report Bookmark**|
|11181|**Agent Resource Forecasting**|
|11182|**[Deprecated] Dynamics Customer Service Analytics**|
|11183|**Case Topic**|
|11184|**Case Topic Setting**|
|11185|**Case Topic Summary**|
|11186|**Case topic Incident mapping**|
|11187|**Case Management Agent analytics**|
|11188|**Customer Service historical analytics**|
|11189|**Email analytics**|
|11190|**Forecast**|
|11191|**Knowledge analytics**|
|11192|**Model Customization analytics**|
|11193|**Real-time analytics for record routing**|
|11194|**Forecast Summary and Setting**|
|11195|**Keywords Description Suggestion Setting**|
|11196|**Bot Variable**|
|11197|**Conversation Summary Interaction**|
|11198|**Conversation Summary Setting**|
|11199|**Conversation Topic**|
|11200|**Conversation Topic Setting**|
|11201|**Conversation Topic Summary**|
|11202|**Conversation topic Conversation mapping**|
|11203|**Omnichannel historical analytics**|
|11204|**Omnichannel voice historical analytics (preview) (Deprecated)**|
|11205|**Omnichannel Realtime analytics**|
|11206|**Copilot Analytics**|
|11207|**Conversation Analytic**|
|11208|**Session Analytics**|
|11209|**Session Participant Analytic**|
|11210|**Evaluation**|
|11211|**Evaluation category**|
|11212|**Evaluation criteria**|
|11213|**Evaluation criteria version**|
|11214|**Evaluation Entity Config**|
|11215|**Evaluation Extension**|
|11216|**Evaluation Global Config**|
|11217|**Evaluation input config**|
|11218|**Evaluation localized content**|
|11219|**Evaluation Notification Configuration**|
|11220|**Evaluation Plan**|
|11221|**Evaluation Plan Batch**|
|11222|**Evaluation Plan Ontrigger Backlog**|
|11223|**Evaluation Plan Run**|
|11224|**Evaluation question**|
|11225|**Criteria Simulation**|
|11226|**PA Flow Run Tracker**|
|11227|**Sales Research Manager**|
|11228|**Engage And Readiness Agent Result V2**|
|11229|**SalesAgentConfigurationV2**|
|11230|**SalesAgentExecutionConfig**|
|11231|**Sales Agent Handover**|
|11232|**Sales agent processing state**|
|11233|**SalesAgentProfile**|
|11234|**Sales agent run**|
|11235|**Trigger Sales Agent**|
|11236|**Account Research Agent Trigger**|
|11237|**Account Research Result**|
|11238|**Account Research Summary Trigger**|
|11239|**Competitor Research Agent Trigger**|
|11240|**Custom Account Insights Result**|
|11241|**Customization Agent Trigger**|
|11242|**Custom OOB Research Result**|
|11243|**Summary Synthesizer Input**|
|11244|**summarysynthesizeroutput (Deprecated)**|
|11245|**Lead Agent Result**|
|11246|**Lead Delink Result**|
|11247|**Lead Email Extension**|
|11248|**Default OOB Account Research Result**|
|11249|**Outreach Agent Result**|
|11250|**Outreach Trigger Agent**|
|11251|**Qualification Agent Trigger**|
|11252|**Sales Agent Configuration**|
|11253|**SalesAgentUsage**|
|11254|**Sales Company Resolver Lead Trigger**|
|11255|**Stakeholder Research Output**|
|11256|**Summary Synthesizer Output**|
|11257|**Summary Synthesizer Agent Trigger**|
|11258|**Target Customer Profile Prefill Agent Result**|
|11259|**TargetCustomerProfilePrefillAgentTrigger**|
|11260|**Web Research Agent Trigger**|
|11261|**Engage And Readiness Agent Result**|
|11263|**Opportunity Account Research Result**|
|11264|**Opportunity Ranker Mapping**|
|11265|**Opportunity Research Agent Trigger**|
|11266|**Opportunity Research Indicator**|
|11267|**Opportunity Research Result**|
|11268|**Opportunity Research User Interactions**|
|11269|**RCS Watermark**|
|11270|**Related Conversation Trigger Table**|
|11271|**Data quality log**|
|11272|**Data quality reassignment**|
|11273|**Data quality source**|
|11274|**Data quality suggestion**|
|11275|**DQA Ranker Trigger**|
|11276|**msdyn_governanceagent_status**|
|11277|**msdyn_guardrail_consumer_mapping**|
|11278|**msdyn_guardrail_execution_info**|
|11279|**msdyn_guardrail_rule**|
|11280|**msdyn_guardrail_rule_version**|
|11281|**msdyn_guardrail_scenariotype**|
|11369|**Requirement Characteristic**|
|11370|**Client Extension**|
|11371|**Booking Setup Metadata**|
|11372|**Configuration**|
|11373|**Bookable Resource Association**|
|11374|**Actual**|
|11375|**Three-Dimensional Model**|
|11376|**Booking Alert**|
|11377|**Booking Alert Status**|
|11378|**Booking Change**|
|11379|**Booking Rule**|
|11380|**Business Closure**|
|11381|**Organizational Unit**|
|11382|**Priority**|
|11383|**Requirement Group**|
|11384|**Requirement Organization Unit**|
|11385|**Requirement Relationship**|
|11386|**Requirement Resource Category**|
|11387|**Requirement Resource Preference**|
|11388|**Requirement Status**|
|11389|**Resource Requirement**|
|11390|**Resource Requirement Detail**|
|11391|**Resource Territory**|
|11392|**Schedule Board Setting**|
|11393|**Scheduling Parameter**|
|11394|**System User Scheduler Setting**|
|11395|**Fulfillment Preference**|
|11396|**Time Group Detail**|
|11397|**Transaction Origin**|
|11398|**Work Template**|
|11399|**Optimization Request**|
|11400|**Requirement Change**|
|11401|**Requirement Dependency**|
|11402|**Scheduling Feature Flag**|
|11403|**Scheduling Scope**|
|11404|**Inspection Template**|
|11405|**Inspection Attachment**|
|11406|**Inspection Template Version**|
|11407|**Inspection**|
|11408|**Inspection Response**|
|11409|**Time Entry**|
|11410|**Time Source**|
|11411|**Payment Term**|
|11412|**Purchase Order**|
|11413|**Purchase Order Product**|
|11414|**Purchase Order Receipt**|
|11415|**Purchase Order Receipt Product**|
|11416|**Ship Via**|
|11417|**Tax Code**|
|11418|**Tax Code Detail**|
|11419|**Warehouse**|
|11420|**Agreement**|
|11421|**Agreement Booking Date**|
|11422|**Agreement Booking Incident**|
|11423|**Agreement Booking Product**|
|11424|**Agreement Booking Service**|
|11425|**Agreement Booking Service Task**|
|11426|**Agreement Booking Setup**|
|11427|**Agreement Invoice Date**|
|11428|**Agreement Invoice Product**|
|11429|**Agreement Invoice Setup**|
|11430|**Agreement Substatus**|
|11431|**Booking Journal**|
|11432|**Booking Timestamp**|
|11433|**Purchase Order Business Process**|
|11434|**Case to Work Order Business Process**|
|11435|**Agreement Business Process**|
|11436|**Work Order Business Process**|
|11437|**Entitlement Application**|
|11438|**Field Service Price List Item**|
|11439|**Field Service Setting**|
|11440|**Field Service SLA Configuration**|
|11441|**Field Service System Job**|
|11442|**Incident Type**|
|11443|**Incident Type Characteristic**|
|11444|**Incident Type Product**|
|11445|**Incident Type Service**|
|11446|**Incident Type Service Task**|
|11447|**Incident Types Setup**|
|11448|**Incident Type Requirement Group**|
|11449|**Inventory Adjustment**|
|11450|**Inventory Adjustment Product**|
|11451|**Inventory Journal**|
|11452|**Inventory Transfer**|
|11453|**Order Invoicing Date**|
|11454|**Order Invoicing Product**|
|11455|**Order Invoicing Setup**|
|11456|**Order Invoicing Setup Date**|
|11457|**Payment**|
|11458|**Payment Detail**|
|11459|**Payment Method**|
|11460|**Postal Code**|
|11461|**Product Inventory**|
|11462|**Purchase Order Bill**|
|11463|**Purchase Order SubStatus**|
|11464|**Quote Booking Incident**|
|11465|**Quote Booking Product**|
|11466|**Quote Booking Service**|
|11467|**Quote Booking Service Task**|
|11468|**Quote Booking Setup**|
|11469|**Quote Invoicing Product**|
|11470|**Quote Invoicing Setup**|
|11471|**Resource Pay Type**|
|11472|**RMA**|
|11473|**RMA Product**|
|11474|**RMA Receipt**|
|11475|**RMA Receipt Product**|
|11476|**RMA SubStatus**|
|11477|**RTV**|
|11478|**RTV Product**|
|11479|**RTV Substatus**|
|11480|**Service Task Type**|
|11481|**Time Off Request**|
|11482|**Unique Number**|
|11483|**Work Order**|
|11484|**Work Order Characteristic (Deprecated)**|
|11485|**Work Order Details Generation Queue (Deprecated)**|
|11486|**Work Order Incident**|
|11487|**Work Order Product**|
|11488|**Resource Restriction (Deprecated)**|
|11489|**Work Order Service**|
|11490|**Work Order Service Task**|
|11491|**Work Order Substatus**|
|11492|**Work Order Type**|
|11494|**Bookable Resource Booking Quick Note**|
|11495|**Field Service Frontline Worker Configuration**|
|11498|**Incident Type Suggestion Result**|
|11499|**Incident Type Suggestion Run History**|
|11500|**Incident Type Resolution**|
|11501|**Insurance**|
|11502|**Not-to-exceed**|
|11503|**Asset Suggestion**|
|11504|**Problematic Asset Feedback**|
|11505|**Resolution**|
|11506|**Trade**|
|11507|**Trade Coverage**|
|11510|**Work order not-to-exceed**|
|11511|**Work Order Resolution**|
|11512|**CFS - IoT Alert Process Flow**|
|11513|**Geolocation Settings**|
|11514|**Geolocation Tracking**|
|11515|**Entity Configuration**|
|11516|**Geofence**|
|11517|**Geofence Event**|
|11518|**Geofencing Settings**|
|11519|**Field Service Summary Configuration**|
|11520|**MobileSource**|
|11693|**Agent Rule**|
|11697|**Twitter handle**|
|11698|**Quiet Time Setting**|
|11699|**channel**|
|11700|**Chat Widget Language(deprecated)**|
|11702|**Facebook Engagement Context**|
|11704|**Channel Profile AI Agent**|
|11705|**Bulk Harvest Run Log**|
|11706|**Harvest Work Item**|
|11707|**Copilot User Workload**|
|11709|**Facebook Application**|
|11713|**OC Twitter Handle Secret**|
|11718|**Screen Recording**|
|11719|**ScreenRecordingLink**|
|11720|**Copilot Organization Workload**|
|11721|**Copilot Skill Mapping**|
|11722|**Agent Source**|
|11723|**AI Agent Status**|
|11724|**Case Management Agent for case closure Activity**|
|11725|**Case Management Agent for case closure Monitoring**|
|11726|**Flow Test Session**|
|11727|**Flow Trigger**|
|11728|**Flow Trigger Instance**|
|11729|**Business Process Linked Artifact**|
|11730|**Always Run SQA Segment**|
|11732|**CC Eventing Scenario**|
|11733|**CC Playbook Policy**|
|11734|**CC User Prompt**|
|11735|**SMS Number**|
|11740|**Recommended Action Derived Insights**|
|11743|**Agent Coach Policy Settings**|
|11745|**OC Apple Pay Entity**|
|11752|**rawactioncatalogue**|
|11754|**Resource Utilization Export**|
|11756|**Contact Center historical analytics**|
|11758|**Evaluation Trigger Config**|
|11759|**Business Skill Resource**|
|11762|**Prioritized Action Catalogue**|
|11772|**Historical Case Harvest Run Log**|
|11774|**Queue User Group Membership**|
|11775|**Harvest Eligibility Condition**|
|11776|**Twitter account**|
|11782|**Facebook Page**|
|11783|**Google's Business Messages agent account**|
|11784|**Scenario**|
|11787|**SMS Engagement Context**|
|11790|**Opportunity Competitor Research Result Cache**|
|11791|**recommendedactionrundetails**|
|11792|**msdyn_recommendedactionsourceagentconfig**|
|11793|**contactprofilerdetail**|
|11794|**contactprofilerresult**|
|11795|**Flow Group**|
|11796|**ComputerUseAgent**|
|11797|**Meeting Prep Insights**|
|11798|**Action**|
|11799|**EvaluationDetails**|
|11800|**EvaluationHistory**|
|11801|**Guardrail**|
|11802|**GuardrailVersion**|
|11803|**IndicatorQuestion**|
|11804|**Monitor**|
|11805|**MonitorAction**|
|11806|**MonitorNotificationConfig**|
|11807|**QINotificationConfig**|
|11808|**QINotificationConfigItem**|
|11809|**QualityIndicator**|
|11810|**QualityIndicatorVersion**|
|11811|**Contact Center Agent Skill Configuration**|
|11812|**RTE Structured Template Config**|
|11814|**Twitter Handle Provisioning Status**|
|11817|**Agent Coach Admin Settings**|
|11819|**Google's Business Messages partner account**|
|11823|**Email Template Language Group**|
|11824|**Email Template Language Group Item**|
|11825|**Agent Metadata Override**|
|11826|**Agent User Preference**|
|11827|**Email thread**|
|11828|**Copilot Tool**|
|11830|**Quality Evaluation Agent analytics**|
|11831|**Knowledge Harvest Plan**|
|11832|**Agent Prompt**|
|11833|**Channel Instance Context Variable**|
|11834|**Common Channel Config**|
|11835|**Conversation Profile**|
|11836|**Profile Picker**|
|11837|**Agent Coach Playbook**|
|11838|**Agent Coach Playbook Instructions**|
|11839|**Case Coaching Result**|
|11840|**Email Coaching Result**|
|11841|**Eval Result**|
|11843|**AthenaReconciliationInfo**|
|11849|**Evaluation Run Config**|
|11850|**Intent Core Evaluation Job**|
|11851|**Intent Family Solution Map**|
|11852|**msdyn_nextbestactionsconfig**|
|11853|**PowerPagesUserMapping**|
|11854|**msdyn_aidescoptimizationrun**|
|11855|**msdyn_aidescriptioncandidate**|
|11856|**msdyn_aidescriptionpublishjob**|
|11857|**msdyn_aidescriptionrun**|
|11858|**msdyn_aidescriptionsettings**|
|11859|**msdyn_aidescriptionvalue**|
|11860|**Agent Assist Bot Config**|
|11861|**Agent Assist Configuration**|
|11862|**Contact Center Agent Skill Setting**|
|11863|**Contact Center Workstream Skill**|
|11864|**Communication Provider Setting**|
|11865|**Communication Provider Setting Entry**|
|11866|**Phone Number**|
|11867|**Carrier**|
|11868|**Custom Model Configuration**|
|11869|**Custom Neural Voice**|
|11870|**SMS Number settings**|
|11871|**Channel instance secret**|
|11872|**SMS Setting Secret**|
|11873|**Cancellation Policy Attributes**|
|11874|**Conversation Attribute**|
|11875|**NRT Configuration Conversation**|
|11876|**Proactive Engagement Planner CallerID Phone Number**|
|11877|**Proactive Engagement Planner CallerID Rule**|
|11878|**Proactive Callback Config**|
|11879|**Proactive Callback Profile**|
|11880|**Proactive Delivery**|
|11881|**Proactive Delivery Attribute**|
|11882|**Proactive Delivery Batch**|
|11883|**Proactive Delivery Batch Error**|
|11884|**Proactive Engagement Configuration**|
|11885|**Proactive Engagement Configuration Attribute**|
|11886|**Proactive Engagement Configuration Status**|
|11887|**Proactive Engagement Message Template**|
|11888|**Delivery Metrics**|
|11889|**Proactive Engagement Planner Configuration**|
|11890|**Proactive Engagement Config Cancellation Policy**|
|11891|**Proactive Engagement Configuration Characteristic**|
|11892|**Custom Messaging Engagement Context**|
|11893|**LINE Engagement Context**|
|11894|**Custom messaging channel**|
|11895|**LINE account**|
|11896|**WeChat account**|
|11897|**WhatsApp account**|
|11898|**WhatsApp number**|
|11899|**Twitter Engagement Context**|
|11900|**WeChat Engagement Context**|
|11901|**WhatsApp Engagement Context**|
|11902|**Apple messages for business account**|
|11903|**Apple messages for business engagement context**|
|11904|**Google's Business Messages engagement context**|
|11905|**AI Agent Consult Setting**|
|11906|**External Security Setting**|
|11907|**Gatekeeper Engagement Context**|
|11908|**Phone Call Engagement Context**|
|11909|**Phone Music**|
|11910|**Voice**|
|11911|**Voice Channel Language Setting**|
|11912|**Voice Channel Setting**|
|11913|**Voicemail**|
|11914|**Voice channel organization setting**|
|11915|**Voice workstream V2 migration status**|
|11916|**Microsoft Teams account**|
|11917|**(Deprecated)Teams Engagement Context**|
|11918|**Teams Engagement Context**|
|11919|**Azure notification hub**|
|11920|**Survey Answer Option**|
|11921|**Survey Response**|
|11922|**Survey Response Value**|
|11923|**Chat Widget**|
|11924|**Live Chat Context**|
|11925|**Chat Widget Location**|
|11926|**Localized Survey Question (Deprecated)**|
|11927|**Survey Question Sequence**|
|11928|**Survey Question**|
|11929|**Web Engagement Ruleset**|
|11930|**Web Engagement Ruleset Config**|
|11931|**Web Engagement Ruleset Revision**|
|11932|**Web Engagement Site Area**|
|11933|**Screen recording config**|
|11934|**Outbound Configuration**|
|11935|**Outbound message**|
|11937|**Scheduling Goal**|
|11938|**Optimization Plan**|
|11939|**Input Requirement**|
|11940|**Input Schedule**|
|11941|**Suggested Schedule**|
|11942|**Unscheduled Requirement**|
|11943|**Source Control Operation Tracking**|
|11944|**Location Record**|
|11945|**Native Extension**|
|11946|**ControlConfiguration**|
|11947|**MOS3 Management**|
|11959|**ML Data Masking Rule**|
|11960|**Unredacted Note**|
|11961|**Conversation Step**|
|11962|**msdyn_guardrail_execution_event**|
|11963|**Message Template**|
|11964|**Proactive Engagement Global Communication Config**|
|11966|**SOA Similar Opportunities**|
|11967|**Business Skill Metadata**|
|11968|**Business Skill Role Mapping**|
|11975|**Email Classification Category Scope Rule**|
|11977|**Intent Harvesting Runtime Result**|
|11978|**Email Template Configuration**|
|11979|**Eval Assertion**|
|11980|**Eval Dataset**|
|11981|**Eval Prompt**|
|11982|**Eval Run**|
|11983|**SCA Engage Agent Result**|
|11984|**Recommended Action Pull Watermark**|

## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_bookingalert_sla_slaid](#BKMK_msdyn_bookingalert_sla_slaid)
- [msdyn_bookingalert_sla_slainvokedid](#BKMK_msdyn_bookingalert_sla_slainvokedid)
- [msdyn_ocoutboundmessage_sla_slaid](#BKMK_msdyn_ocoutboundmessage_sla_slaid)
- [msdyn_ocoutboundmessage_sla_slainvokedid](#BKMK_msdyn_ocoutboundmessage_sla_slainvokedid)
- [msdyn_ocvoicemail_sla_slaid](#BKMK_msdyn_ocvoicemail_sla_slaid)
- [msdyn_ocvoicemail_sla_slainvokedid](#BKMK_msdyn_ocvoicemail_sla_slainvokedid)

### <a name="BKMK_msdyn_bookingalert_sla_slaid"></a> msdyn_bookingalert_sla_slaid

Many-To-One Relationship: [msdyn_bookingalert msdyn_bookingalert_sla_slaid](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_sla_slaid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingalert_sla_slaid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10001<br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_msdyn_bookingalert_sla_slainvokedid"></a> msdyn_bookingalert_sla_slainvokedid

Many-To-One Relationship: [msdyn_bookingalert msdyn_bookingalert_sla_slainvokedid](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_sla_slainvokedid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingalert_sla_slainvokedid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocoutboundmessage_sla_slaid"></a> msdyn_ocoutboundmessage_sla_slaid

Many-To-One Relationship: [msdyn_ocoutboundmessage msdyn_ocoutboundmessage_sla_slaid](msdyn_ocoutboundmessage.md#BKMK_msdyn_ocoutboundmessage_sla_slaid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocoutboundmessage_sla_slaid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10001<br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_msdyn_ocoutboundmessage_sla_slainvokedid"></a> msdyn_ocoutboundmessage_sla_slainvokedid

Many-To-One Relationship: [msdyn_ocoutboundmessage msdyn_ocoutboundmessage_sla_slainvokedid](msdyn_ocoutboundmessage.md#BKMK_msdyn_ocoutboundmessage_sla_slainvokedid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocoutboundmessage_sla_slainvokedid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocvoicemail_sla_slaid"></a> msdyn_ocvoicemail_sla_slaid

Many-To-One Relationship: [msdyn_ocvoicemail msdyn_ocvoicemail_sla_slaid](msdyn_ocvoicemail.md#BKMK_msdyn_ocvoicemail_sla_slaid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocvoicemail_sla_slaid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10001<br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_msdyn_ocvoicemail_sla_slainvokedid"></a> msdyn_ocvoicemail_sla_slainvokedid

Many-To-One Relationship: [msdyn_ocvoicemail msdyn_ocvoicemail_sla_slainvokedid](msdyn_ocvoicemail.md#BKMK_msdyn_ocvoicemail_sla_slainvokedid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocvoicemail_sla_slainvokedid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.sla?displayProperty=fullName>
