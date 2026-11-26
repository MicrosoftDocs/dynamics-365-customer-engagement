---
title: "SLA table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the SLA table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# SLA table/entity reference (Microsoft Dynamics 365)

Contains information about the tracked service-level KPIs for cases that belong to different customers.

> [!NOTE]
> The Microsoft Dynamics 365 SLA table extends the [Microsoft Dataverse SLA table](/power-apps/developer/data-platform/reference/entities/sla).



## Customized columns/attributes

Microsoft Dynamics 365 modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_ObjectTypeCode"></a> ObjectTypeCode

Changes from [ObjectTypeCode (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/sla#BKMK_ObjectTypeCode)

#### ObjectTypeCode Choices/Options

|Value|Label|
|---|---|
|3|**Opportunity**|
|4|**Lead**|
|16|**AccountLeads**|
|17|**ContactInvoices**|
|18|**ContactQuotes**|
|19|**ContactOrders**|
|20|**Service Contract Contact**|
|21|**ProductSalesLiterature**|
|22|**ContactLeads**|
|24|**LeadCompetitors**|
|25|**OpportunityCompetitors**|
|26|**CompetitorSalesLiterature**|
|27|**LeadProduct**|
|32|**Sales Process Instance**|
|112|**Case**|
|113|**Child Incident Count**|
|123|**Competitor**|
|952|**Phone To Case Process**|
|953|**Opportunity Sales Process**|
|954|**Lead To Opportunity Sales Process**|
|1004|**Competitor Address**|
|1006|**Competitor Product**|
|1010|**Contract**|
|1011|**Contract Line**|
|1013|**Discount**|
|1017|**Lead Address**|
|1022|**Price List**|
|1024|**Product**|
|1025|**Product Association**|
|1026|**Price List Item**|
|1028|**Product Relationship**|
|1038|**Sales Literature**|
|1048|**Property**|
|1049|**Property Option Set Item**|
|1055|**Unit**|
|1056|**Unit Group**|
|1070|**Sales Attachment**|
|1080|**Discount List**|
|1083|**Opportunity Product**|
|1084|**Quote**|
|1085|**Quote Product**|
|1088|**Order**|
|1089|**Order Product**|
|1090|**Invoice**|
|1091|**Invoice Product**|
|1141|**Characteristic**|
|1142|**Rating Value**|
|1144|**Rating Model**|
|1145|**Bookable Resource Booking**|
|1146|**Bookable Resource Booking Header**|
|1147|**Bookable Resource Category**|
|1148|**Bookable Resource Characteristic**|
|1149|**Bookable Resource Category Assn**|
|1150|**Bookable Resource**|
|1151|**Bookable Resource Group**|
|1152|**Booking Status**|
|1235|**Property Association**|
|1333|**Property Instance**|
|2011|**Contract Template**|
|4000|**Facility/Equipment**|
|4001|**Service**|
|4002|**Resource**|
|4005|**Scheduling Group**|
|4006|**Resource Specification**|
|4007|**Resource Group**|
|4009|**Site**|
|4010|**Resource Expansion**|
|4206|**Case Resolution**|
|4208|**Opportunity Close**|
|4209|**Order Close**|
|4211|**Quote Close**|
|4214|**Service Activity**|
|4215|**Commitment**|
|4300|**Marketing List**|
|4301|**Marketing List Member**|
|4400|**Campaign**|
|4401|**Campaign Response**|
|4402|**Campaign Activity**|
|4403|**Campaign Item**|
|4404|**Campaign Activity Item**|
|4405|**Bulk Operation Log**|
|4406|**Quick Campaign**|
|4421|**Bookable Resource Booking to Exchange Id Mapping**|
|4503|**Opportunity Relationship**|
|4545|**Entitlement Template Product**|
|6363|**Entitlement Product**|
|7272|**Entitlement Contact**|
|9700|**Entitlement**|
|9701|**Entitlement Channel**|
|9702|**Entitlement Template**|
|9703|**Entitlement Template Channel**|
|9704|**Entitlement Entity Allocation Type Mapping**|
|9931|**Incident KnowledgeBaseRecord**|
|9942|**Topic Model Configuration**|
|9943|**Topic Model Execution History**|
|9944|**Topic Model**|
|9946|**Topic History**|
|9948|**Text Analytics Topic**|
|9954|**Knowledge Article Incident**|
|10008|**StageSolutionUpload**|
|10009|**ExportSolutionUpload**|
|10010|**FeatureControlSetting**|
|10011|**Package**|
|10012|**Package History**|
|10048|**Entity Storage Profile**|
|10049|**Policy Criterion**|
|10050|**App Notification Signal**|
|10051|**Shared Object**|
|10052|**Shared Workspace**|
|10053|**Shared Workspace Access Token**|
|10054|**Shared Workspace Pool**|
|10055|**Data Lake Folder**|
|10056|**Data Lake Folder Permission**|
|10057|**Data Lake Workspace**|
|10058|**Data Lake Workspace Permission**|
|10059|**Data Processing configuration**|
|10060|**Exported Excel**|
|10061|**RetainedData Excel**|
|10062|**Synapse Database**|
|10063|**AthenaReconciliationInfo**|
|10064|**Synapse Link External Table State**|
|10065|**Synapse Link Profile**|
|10066|**Synapse Link Profile Entity**|
|10067|**Synapse Link Profile Entity State**|
|10068|**Synapse Link Schedule**|
|10069|**Component Changeset Payload**|
|10070|**Component Changeset Version**|
|10071|**Component Version**|
|10072|**Component Version Data Source**|
|10073|**Component Version (Internal)**|
|10074|**DataflowRefreshHistory**|
|10075|**EntityRefreshHistory**|
|10076|**Shared Link Setting**|
|10077|**Any Privilege Entity**|
|10078|**DelegatedAuthorization**|
|10080|**CascadeGrantRevokeAccessRecordsTracker**|
|10081|**CascadeGrantRevokeAccessVersionTracker**|
|10082|**RevokeInheritedAccessRecordsTracker**|
|10083|**TdsMetadata**|
|10084|**Model-Driven App Element**|
|10085|**Model-Driven App Component Node's Edge**|
|10086|**Model-Driven App Component Node**|
|10087|**Model-Driven App Setting**|
|10088|**Model-Driven App User Setting**|
|10089|**Organization Setting**|
|10090|**Setting Definition**|
|10091|**CanvasApp Extended Metadata**|
|10092|**Service Plan Mapping**|
|10093|**Service Plan Custom Control**|
|10095|**ApplicationUser**|
|10098|**Git Branch**|
|10099|**Git Configuration Retrieval Data Source**|
|10100|**GitHubAppConfig**|
|10101|**Git Organization**|
|10102|**Git Project**|
|10103|**Git Repository**|
|10104|**Git Solution**|
|10105|**Source Control Branch Configuration**|
|10106|**Source Control Component**|
|10107|**Source Control Component Payload**|
|10108|**Source Control Configuration**|
|10109|**Source Control Operation Status**|
|10110|**Source Control Operation Tracking**|
|10111|**Staged Source Control Component**|
|10112|**OData v4 Data Source**|
|10113|**Workflow Binary**|
|10114|**Flow Group**|
|10115|**Business Process**|
|10116|**ComputerUseAgent**|
|10117|**Credential**|
|10118|**Desktop Flow Module**|
|10119|**Flow Capacity Assignment**|
|10120|**Flow Credential Application**|
|10121|**Flow Event**|
|10122|**Flow Machine**|
|10123|**Flow Machine Group**|
|10124|**Flow Machine Image**|
|10125|**Flow Machine Image Version**|
|10126|**Flow Machine Network**|
|10127|**Flow Session Binary**|
|10128|**Flow Test Session**|
|10129|**Flow Trigger**|
|10130|**Flow Trigger Instance**|
|10131|**ProcessStageParameter**|
|10132|**Saving Rule**|
|10133|**Tag**|
|10134|**Tagged Flow Session**|
|10135|**Tagged Process**|
|10136|**Workflow Metadata**|
|10137|**Work Queue**|
|10138|**Work Queue Item**|
|10139|**Desktop Flow Binary**|
|10140|**Flow Aggregation**|
|10141|**Flow Log**|
|10142|**Flow Run**|
|10143|**Approval Process**|
|10144|**Approval Stage Approval**|
|10145|**Approval Stage Condition**|
|10146|**Approval Stage Intelligent**|
|10147|**Approval Stage Order**|
|10148|**Action Approval Model**|
|10149|**Approval**|
|10150|**Approval Request**|
|10151|**Approval Response**|
|10152|**Approval Step**|
|10153|**Await All Action Approval Model**|
|10154|**Await All Approval Model**|
|10155|**Basic Approval Model Data**|
|10156|**Flow Approval**|
|10165|**Connection Reference**|
|10166|**Knowledge Source Consumer**|
|10167|**Knowledge Source Profile**|
|10168|**UnstructuredFileSearchEntity**|
|10169|**UnstructuredFileSearchRecord**|
|10170|**UnstructuredFileSearchRecordStatus**|
|10171|**DVFileSearch**|
|10172|**DVFileSearchAttribute**|
|10173|**DVFileSearchEntity**|
|10174|**DVTableSearch**|
|10175|**DVTableSearchAttribute**|
|10176|**DVTableSearchEntity**|
|10177|**AICopilot**|
|10178|**AIPluginAuth**|
|10179|**AI Plugin Conversation Starter**|
|10180|**AI Plugin Conversation Starter Mapping**|
|10181|**AI Plugin Governance**|
|10182|**AI Plugin Governance Extended**|
|10183|**AIPluginOperationResponseTemplate**|
|10184|**AIPluginTitle**|
|10185|**SideloadedAIPlugin**|
|10186|**AIPlugin**|
|10187|**AIPluginExternalSchema**|
|10188|**AIPluginExternalSchemaProperty**|
|10189|**AIPluginInstance**|
|10190|**AIPluginOperation**|
|10191|**AIPluginOperationParameter**|
|10192|**AIPluginUserSetting**|
|10194|**AI Configuration Search**|
|10195|**Data Processing Event**|
|10196|**AI Document Template**|
|10197|**AI Event**|
|10198|**AI Model Catalog**|
|10200|**AI Builder Feedback Loop**|
|10201|**AI Form Processing Document**|
|10202|**AI Object Detection Image**|
|10203|**AI Object Detection Label**|
|10204|**AI Object Detection Bounding Box**|
|10205|**AI Object Detection Image Mapping**|
|10207|**AI Builder Dataset**|
|10208|**AI Builder Dataset File**|
|10209|**AI Builder Dataset Record**|
|10210|**AI Builder Datasets Container**|
|10211|**AI Builder File**|
|10212|**AI Builder File Attached Data**|
|10213|**AI Evaluation Configuration**|
|10214|**AI Evaluation Metric**|
|10215|**AI Evaluation Run**|
|10216|**AI Optimization**|
|10217|**AI Optimization Private Data**|
|10218|**AI Test Case**|
|10219|**AI Test Case Document**|
|10220|**AI Test Case Input**|
|10221|**AI Test Run**|
|10222|**AI Test Run Batch**|
|10223|**Help Page**|
|10224|**Tour**|
|10225|**BotContent**|
|10226|**ConversationTranscript**|
|10227|**Agent**|
|10228|**Agent component**|
|10229|**Agent component collection**|
|10240|**Comment**|
|10241|**Governance Configuration**|
|10242|**Fabric AISkill**|
|10243|**App Insights Metadata**|
|10244|**Dataflow Connection Reference**|
|10245|**Schedule**|
|10246|**Dataflow Template**|
|10247|**Dataflow DatalakeFolder**|
|10248|**Data Movement Service Request**|
|10249|**Data Movement Service Request Status**|
|10250|**DMS Sync Request**|
|10251|**DMS Sync Status**|
|10252|**Knowledge Asset Configuration**|
|10253|**Module Run Detail**|
|10254|**QnA**|
|10255|**Salesforce Structured Object**|
|10256|**Salesforce Structured QnA Config**|
|10257|**Workflow Action Status**|
|10258|**Allowed MCP Client**|
|10259|**FederatedKnowledgeCitation**|
|10260|**FederatedKnowledgeConfiguration**|
|10261|**FederatedKnowledgeEntityConfiguration**|
|10262|**FederatedKnowledgeMetadataRefresh**|
|10263|**IntelligentMemory**|
|10264|**Knowledge FAQ**|
|10265|**Eval Result**|
|10266|**Form Mapping**|
|10267|**Copilot Interactions**|
|10268|**PDF Setting**|
|10269|**Activity File Attachment**|
|10270|**Teams chat**|
|10271|**Service Configuration**|
|10272|**SLA KPI**|
|10273|**Integrated search provider**|
|10274|**Knowledge Management Setting**|
|10275|**Knowledge Federated Article**|
|10276|**Knowledge Federated Article Incident**|
|10277|**Search provider**|
|10278|**Knowledge Article Image**|
|10279|**Knowledge Configuration**|
|10280|**Knowledge Interaction Insight**|
|10281|**Knowledge Search Insight**|
|10282|**Favorite knowledge article**|
|10283|**Knowledge article language setting**|
|10284|**Knowledge Article Attachment**|
|10285|**Knowledge personalization**|
|10286|**Knowledge Article Template**|
|10287|**Knowledge search personal filter config**|
|10288|**Knowledge search filter**|
|10290|**SupportUserTable**|
|10291|**FxExpression**|
|10292|**Function**|
|10293|**Plug-in**|
|10294|**PowerfxRule**|
|10295|**Planner Business Scenario**|
|10296|**Planner Sync Action**|
|10297|**Agent Rule**|
|10298|**MCPPrompt**|
|10299|**MCPResource**|
|10300|**MCPResourceContent**|
|10301|**MCPServer**|
|10302|**MCPTool**|
|10303|**ToolingGateway**|
|10304|**ToolingGatewayMCPServer**|
|10305|**Email Address Configuration**|
|10306|**Ms Graph Resource To Subscription**|
|10307|**Virtual Entity  Metadata**|
|10308|**Background Operation**|
|10309|**Report Parameter**|
|10310|**MobileOfflineProfileExtension**|
|10311|**MobileOfflineProfileItemFilter**|
|10312|**TeamMobileOfflineProfileMembership**|
|10313|**UserMobileOfflineProfileMembership**|
|10314|**OrganizationDataSyncSubscription**|
|10315|**OrganizationDataSyncSubscriptionEntity**|
|10316|**OrganizationDataSyncSubscriptionFnoTable**|
|10317|**OrganizationDataSyncFnoState**|
|10318|**OrganizationDataSyncState**|
|10319|**ArchiveCleanupInfo**|
|10320|**ArchiveCleanupOperation**|
|10321|**BulkArchiveConfig**|
|10322|**BulkArchiveFailureDetail**|
|10323|**BulkArchiveOperation**|
|10324|**BulkArchiveOperationDetail**|
|10325|**EnableArchivalRequest**|
|10326|**MetadataForArchival**|
|10327|**ReconciliationEntityInfo**|
|10328|**ReconciliationEntityStepInfo**|
|10329|**ReconciliationInfo**|
|10330|**RetentionCleanupInfo**|
|10331|**RetentionCleanupOperation**|
|10332|**Data Life Cycle Config**|
|10333|**RetentionFailureDetail**|
|10334|**RetentionOperation**|
|10335|**RetentionOperationDetail**|
|10336|**RetentionSuccessDetail**|
|10337|**CertificateCredential**|
|10338|**Notification**|
|10339|**User Rating**|
|10340|**Location Record**|
|10341|**Mobile App**|
|10342|**Native Extension**|
|10343|**Power Apps Wrap Build**|
|10344|**Insights Store Data Source**|
|10345|**Insights Store Virtual Entity**|
|10346|**RoleEditorLayout**|
|10347|**Deleted Record Reference**|
|10348|**Restore Deleted Records Configuration**|
|10349|**App Action**|
|10350|**App Action Migration**|
|10351|**App Action Rule**|
|10354|**Card**|
|10355|**Card State Item**|
|10358|**Entity link chat configuration**|
|10359|**Agent Feed Item**|
|10360|**Agent Hub Goal**|
|10361|**Agent Hub Insight**|
|10362|**Agent Hub Metric**|
|10363|**Agentic Scenario**|
|10364|**Agent Memory**|
|10365|**Agent Prompt**|
|10366|**Agent Task**|
|10367|**SharePoint Managed Identity**|
|10368|**ControlConfiguration**|
|10369|**AI Insight Card**|
|10370|**AI Skill Config**|
|10371|**Suggested Action**|
|10372|**Suggested Action Criteria**|
|10373|**Data Workspace**|
|10374|**Plan**|
|10375|**Plan Artifact**|
|10376|**Plan Attachment**|
|10377|**UX Agent Component**|
|10378|**UX Agent Component Revision**|
|10379|**UX Agent Project**|
|10380|**UX Agent Project File**|
|10381|**Agent Conversation Message**|
|10382|**Agent Conversation Message File**|
|10383|**Rich Text Attachment**|
|10384|**Structured Template**|
|10385|**RTE Structured Template Config**|
|10386|**RTE Template Mapping**|
|10387|**Custom Control Extended Setting**|
|10388|**Timeline Pin**|
|10389|**Virtual Connector Data Source**|
|10390|**Virtual Table Column Candidate**|
|10392|**PM Analysis History**|
|10393|**PM Business Rule Automation Config**|
|10394|**PM Calendar**|
|10395|**PM Calendar Version**|
|10396|**PM Inferred Task**|
|10397|**PM Process Extended Metadata Version**|
|10398|**PM Process Template**|
|10399|**PM Process User Settings**|
|10400|**PM Process Version**|
|10401|**PM Recording**|
|10402|**PM Simulation**|
|10403|**PM Tab**|
|10404|**PM Template**|
|10405|**PM View**|
|10406|**Analysis Component**|
|10407|**Analysis Job**|
|10408|**Analysis Override**|
|10409|**Analysis Result**|
|10410|**Analysis Result Detail**|
|10411|**Solution Health Rule**|
|10412|**Solution Health Rule Argument**|
|10413|**Solution Health Rule Set**|
|10414|**File Upload**|
|10415|**AppEntitySearchView**|
|10416|**MainFewShot**|
|10417|**MakerFewShot**|
|10418|**SearchAttributeSettings**|
|10419|**SearchCustomAnalyzer**|
|10420|**SearchRelationshipSettings**|
|10421|**SearchResultsCache**|
|10422|**Search Telemetry**|
|10423|**Business Skill Metadata**|
|10424|**Business Skill Role Mapping**|
|10425|**TextDataRecordsIndexingStatus**|
|10426|**ViewAsExampleQuestion**|
|10427|**CopilotExampleQuestion**|
|10428|**CopilotGlossaryTerm**|
|10429|**CopilotSynonyms**|
|10430|**Business Skill**|
|10431|**Business Skill Resource**|
|10433|**Site Component**|
|10434|**Site**|
|10435|**Site Language**|
|10436|**Power Pages Site Published**|
|10437|**Site Source File**|
|10440|**External Identity**|
|10441|**Invitation**|
|10442|**Invite Redemption**|
|10443|**Portal Comment**|
|10444|**Setting**|
|10445|**Multistep Form Session**|
|10449|**Ad Placement**|
|10450|**Column Permission**|
|10451|**Column Permission Profile**|
|10452|**Content Snippet**|
|10453|**Basic Form**|
|10454|**Basic Form Metadata**|
|10455|**List**|
|10456|**Table Permission**|
|10457|**Page Template**|
|10458|**Poll Placement**|
|10459|**Power Pages Core Entity DS**|
|10460|**Publishing State**|
|10461|**Publishing State Transition Rule**|
|10462|**Redirect**|
|10463|**Shortcut**|
|10464|**Site Marker**|
|10465|**Site Setting**|
|10466|**Web File**|
|10467|**Multistep Form**|
|10468|**Multistep Form Metadata**|
|10469|**Form Step**|
|10470|**Web Link**|
|10471|**Web Link Set**|
|10472|**Web Page**|
|10473|**Web Page Access Control Rule**|
|10474|**Web Role**|
|10475|**Website**|
|10476|**Website Access**|
|10477|**Website Language**|
|10478|**Web Template**|
|10485|**Power Pages Scan Report**|
|10486|**PowerPagesDDOSAlert**|
|10487|**Power Pages Log**|
|10488|**PowerPagesManagedIdentity**|
|10489|**Power Pages Site AI Feedback**|
|10490|**PowerPagesUserMapping**|
|10496|**Catalog Submission Files**|
|10497|**Package Submission Store**|
|10498|**indexedtrait**|
|10499|**processor registration**|
|10500|**signal**|
|10501|**signal registration**|
|10502|**trait**|
|10503|**trait registration**|
|10504|**MOS3 Management**|
|10505|**List Operation**|
|10506|**Marketing Form Display Attributes**|
|10507|**Database Version**|
|10508|**Upgrade Run**|
|10509|**Upgrade Step**|
|10510|**Upgrade Version**|
|10511|**Activity monitor**|
|10512|**Originating Queue Mapping**|
|10514|**Unified Routing Setup Tracker**|
|10515|**Available Times**|
|10516|**Available Times Data Source**|
|10517|**resource group data source**|
|10518|**Virtual Resource Group Resource**|
|10519|**Migration tracker**|
|10520|**Asset Category Template Association**|
|10521|**Asset Template Association**|
|10522|**Customer Asset**|
|10525|**Customer Asset Attachment**|
|10526|**Customer Asset Category**|
|10527|**Functional Location**|
|10528|**Functional Location Type**|
|10529|**Location Template Association**|
|10530|**Functional Location Type Template Association**|
|10531|**Property Definition**|
|10532|**Property Asset Association**|
|10533|**Property Location Association**|
|10534|**Property Log**|
|10535|**Property Template Association**|
|10536|**Template For Properties**|
|10537|**Warranty**|
|10544|**IoT Alert**|
|10545|**IoT Device**|
|10546|**IoT Device Category**|
|10547|**IoT Device Command**|
|10548|**IoT Device Command Definition**|
|10549|**IoT Device Data History**|
|10550|**IoT Device Property**|
|10551|**IoT Device Registration History**|
|10552|**IoT Device Visualization Configuration**|
|10553|**IoT Field Mapping**|
|10554|**IoT Property Definition**|
|10555|**IoT Provider**|
|10556|**IoT Provider Instance**|
|10557|**IoT Settings**|
|10560|**IoT Alert to Case Process**|
|10562|**Playbook Callable Context**|
|10563|**Playbook activity**|
|10564|**Playbook activity attribute**|
|10565|**[DEPRECATED] Playbook category**|
|10566|**Playbook**|
|10567|**[DEPRECATED] Playbook template**|
|10569|**admin_settings_entity**|
|10570|**Collab Space Team Association**|
|10571|**CRM Activity Mapping**|
|10572|**CRM Connection**|
|10573|**Derived insights related entity**|
|10574|**Entity derived insights**|
|10575|**External CRM**|
|10576|**External Record**|
|10577|**Lead Intelligence Insight**|
|10578|**Lead Intelligence Insight Entity Link**|
|10579|**Meeting Prep Insights**|
|10580|**msdyn_rawinsight**|
|10581|**msdyn_rawinsightentitylink**|
|10582|**Tagged Record**|
|10583|**M365 Copilot Sales customer list**|
|10584|**msdyn_vivaentitysetting**|
|10585|**msdyn_vivaorgextensioncred**|
|10586|**msdyn_vivaorgsetting**|
|10587|**msdyn_vivausersetting**|
|10588|**Activity Mapping**|
|10589|**Sales Copilot Email Insight**|
|10590|**Sales Copilot Insight**|
|10591|**Sales Copilot Insight Card State**|
|10592|**Sales Copilot Job Status**|
|10593|**Sales Copilot Knowledge Base**|
|10594|**Org level settings for Sales Copilot apps**|
|10595|**Sales Copilot User Setting**|
|10596|**App profile**|
|10597|**Application Extension**|
|10598|**Application Tab Template**|
|10599|**App profile role mapping**|
|10600|**Notification Field**|
|10601|**Notification Template**|
|10602|**Session Template**|
|10603|**Template Parameter**|
|10609|**Channel Integration Framework v1.0 Provider**|
|10610|**Notification Field (Deprecated)**|
|10611|**Notification Template (Deprecated)**|
|10612|**App Parameter Definition (Deprecated)**|
|10613|**Session Templates (Deprecated)**|
|10614|**Application Tab Template (Deprecated)**|
|10615|**Parameter (Deprecated)**|
|10616|**Template Tag (Deprecated)**|
|10617|**Application Type (Deprecated)**|
|10626|**Channel Integration Framework v2.0 Provider**|
|10628|**Conversation Data (Deprecated)**|
|10629|**KPI Event Data**|
|10630|**KPI Event Definition**|
|10631|**Session Data (Deprecated)**|
|10632|**Session Participant Data (Deprecated)**|
|10633|**Channel Definition**|
|10634|**Channel Definition Consent**|
|10635|**Channel Definition Locale**|
|10636|**Channel Instance**|
|10637|**Channel Instance Account**|
|10638|**Channel Message Attachment**|
|10639|**Channel Message Context Part**|
|10640|**Channel Message Part**|
|10641|**Consuming Application**|
|10642|**msdyn_DefExtendedChannelInstance**|
|10643|**msdyn_DefExtendedChannelInstanceAccount**|
|10644|**Productivity pane configuration**|
|10645|**Pane tab configuration**|
|10646|**Pane tool configuration**|
|10648|**Script**|
|10649|**Script step**|
|10651|**Action Input Parameter**|
|10652|**Action Output Parameter**|
|10653|**Macro Action Template**|
|10654|**Macro Solution Configuration**|
|10655|**Macro Connector**|
|10656|**Macro Run History**|
|10657|**Parameter definition**|
|10660|**Adaptive Card Configuration**|
|10661|**Smartassist configuration**|
|10663|**Read Tracker**|
|10664|**Read tracking enabled information**|
|10665|**Microsoft Teams Graph resource Entity**|
|10666|**msdyn_msteamssetting**|
|10667|**msdyn_msteamssettingsv2**|
|10668|**Microsoft Teams Collaboration entity**|
|10669|**Teams Dialer Admin settings**|
|10670|**Teams Contact Suggestion by AI**|
|10671|**Contact suggestion rule**|
|10672|**Contact suggestion ruleset**|
|10673|**Microsoft Teams chat association entity**|
|10674|**Microsoft Teams chat suggestion**|
|10675|**Hierarchy Configuration**|
|10676|**Microsoft Orgchart node entity**|
|10677|**Forecast Manual Adjustment History**|
|10678|**Distributed Lock**|
|10679|**Entity Delta Change**|
|10680|**File Upload Status Tracker**|
|10681|**Forecast**|
|10682|**Forecast Configuration**|
|10683|**Forecast definition**|
|10684|**Forecasting Cache**|
|10685|**Forecast Insights**|
|10686|**Forecast**|
|10687|**Forecast Prediction Data**|
|10688|**Forecast Prediction Status**|
|10689|**Forecast recurrence**|
|10690|**Recompute Tracker**|
|10691|**Forecast Recurrence**|
|10692|**ShareAs Configuration**|
|10693|**Customer email communication**|
|10694|**GDPRData**|
|10695|**ODOSFeatureMetadata**|
|10696|**ODOSMetadata**|
|10697|**Recurring Sales Action**|
|10698|**Recurring Sales Action V2**|
|10699|**msdyn_relationshipinsightsunifiedconfig**|
|10700|**siconfig**|
|10701|**SI Key Value Config**|
|10702|**Usage Metric**|
|10703|**Action Card Regarding**|
|10704|**Action Card Role Setting**|
|10705|**EntityRankingRule**|
|10706|**flowcardtype**|
|10707|**salesinsightssettings**|
|10708|**Action Card Usage**|
|10709|**Action Card Usage Aggregation**|
|10710|**Auto Capture Rule**|
|10711|**Auto Capture Settings**|
|10712|**UntrackedAppointment**|
|10713|**Suggested Activity**|
|10714|**Suggested Activity Data Source**|
|10715|**Suggested Contact**|
|10716|**Suggested Contacts Data Source**|
|10717|**Notes analysis Config**|
|10718|**icebreakersconfig**|
|10719|**dealmanageraccess**|
|10720|**Deal manager settings**|
|10721|**Account KPI Item**|
|10722|**Activity Analysis CleanUp State**|
|10723|**Relationship Analytics Config**|
|10724|**Contact KPI Item**|
|10725|**Daily Kpis for account**|
|10726|**Daily kpis for contact**|
|10727|**Daily kpis for lead**|
|10728|**Daily kpis for Opportunity**|
|10729|**Lead KPI Item**|
|10730|**Most Contacted**|
|10731|**Most Contacted By**|
|10732|**Opportunity KPI Item**|
|10733|**Relationship Analytics Metadata**|
|10734|**Similar entities feature importance**|
|10735|**wkwcolleaguesforcompany**|
|10736|**wkwcolleaguesforcontact**|
|10737|**wkwconfig**|
|10738|**Attribute Influence Statistics**|
|10739|**Prediction Computation Operation**|
|10740|**Prediction Model Status**|
|10741|**Prediction Scheduled Operation**|
|10742|**Predictive Model Score**|
|10743|**Predictive Score**|
|10744|**Predictive Scoring Sync Status**|
|10745|**Real Time Scoring**|
|10746|**Real Time Scoring Operation**|
|10747|**Submodel Definition**|
|10748|**Time spent in BPF**|
|10749|**Training Result**|
|10750|**OpportunityModelConfig**|
|10751|**LeadModelConfig**|
|10752|**ModelPreviewStatus**|
|10753|**Profile Album**|
|10754|**Post Configuration**|
|10755|**Post Rule Configuration**|
|10756|**Wall View**|
|10757|**Filter**|
|10758|**Customer Voice alert**|
|10759|**Customer Voice alert rule**|
|10760|**Customer Voice user activity**|
|10761|**Customer Voice survey email template**|
|10762|**Customer Voice file response**|
|10763|**Customer Voice localized survey email template**|
|10764|**Customer Voice Log**|
|10765|**Customer Voice project**|
|10766|**Customer Voice survey question**|
|10767|**Customer Voice survey question response**|
|10768|**Customer Voice satisfaction metric**|
|10769|**Customer Voice Satisfaction Metric Aggregate**|
|10770|**Customer Voice Satisfaction Metric Survey Mapping**|
|10771|**Shorturl**|
|10772|**Customer Voice survey**|
|10773|**Customer Voice survey invite**|
|10774|**Customer Voice survey invite summary**|
|10775|**Customer Voice survey reminder**|
|10776|**Customer Voice survey response**|
|10777|**Customer Voice unsubscribed recipient**|
|10778|**Customer Service Key Value Configuration**|
|10779|**AddToCalendar style**|
|10780|**basestyle**|
|10781|**Button style**|
|10782|**Code style**|
|10783|**Column style**|
|10784|**Content Block**|
|10785|**Divider style**|
|10786|**General styles**|
|10787|**imagestyle**|
|10788|**Layout Style**|
|10789|**QR code style**|
|10790|**Text style**|
|10791|**Video style**|
|10792|**Email Template Language Group**|
|10793|**Email Template Language Group Item**|
|10794|**App state**|
|10795|**CSAdminConfig**|
|10796|**Product Map**|
|10797|**Custom API Ruleset Configuration**|
|10798|**Decision contract**|
|10799|**Decision rule set**|
|10800|**Rulesetentitymapping**|
|10801|**Routing diagnostic item**|
|10802|**Routing diagnostic**|
|10803|**Template Context Variable**|
|10804|**Template Rule Set**|
|10805|**Template Variable Batch Operation**|
|10807|**Inbox card configuration**|
|10808|**Inbox Configuration**|
|10809|**Inbox Entity Configuration**|
|10810|**Inbox Personalized Configuration**|
|10811|**App Profile Copilot Configuration**|
|10812|**Swarm**|
|10813|**Swarm participant**|
|10814|**Swarm participant rule**|
|10815|**Swarm role**|
|10816|**Swarm skill**|
|10817|**Swarm template**|
|10818|**Autonomous case creation and update rules**|
|10819|**CHT App Profile Configuration**|
|10820|**Entity Attachment**|
|10821|**Time Tracker**|
|10822|**Customer feedback survey**|
|10823|**Customer feedback survey invite**|
|10824|**Customer feedback survey response**|
|10825|**msdyn_surveyconfig**|
|10826|**Survey setting**|
|10827|**Entity Attribute Prediction Rule**|
|10828|**emailclassificationcategory**|
|10829|**Email Classification Category Scope Rule**|
|10830|**emailclassificationcategoryversion**|
|10831|**Email Sentiment**|
|10833|**Agent Configuration**|
|10834|**Autonomous Agent Entity Mapping**|
|10835|**Autonomous Profile**|
|10836|**Rollout Plan**|
|10837|**Screen recording config**|
|10838|**Agent Metadata Override**|
|10839|**Agent User Preference**|
|10840|**Master Entity Routing Configuration**|
|10841|**Routing Rule Set Setting**|
|10842|**Assignment Configuration**|
|10843|**Assignment Configuration Step**|
|10844|**Capacity Profile**|
|10845|**msdyn_globalrulesetconfiguration**|
|10846|**Last Agent**|
|10847|**Overflow Action Config**|
|10848|**Preferred Agent**|
|10849|**Preferred Agent Customer Identity**|
|10850|**Preferred Agent Routed Entity**|
|10851|**Routing configuration**|
|10852|**Routing configuration step**|
|10853|**Bot Channel Registration**|
|10854|**Channel Configuration**|
|10855|**Channel State Configuration**|
|10856|**Provisioning State**|
|10857|**AdminAppState**|
|10858|**Agent Status history**|
|10859|**Power BI Configuration**|
|10860|**Authentication Settings**|
|10861|**Auth Settings Entry**|
|10862|**Quick reply**|
|10863|**Entity Routing Context**|
|10864|**Channel Capability**|
|10865|**Conversation Action**|
|10866|**Conversation Action Locale**|
|10867|**Conversation Message Block**|
|10868|**DeletedConversation**|
|10869|**Deprecated Workstream Entity Configuration**|
|10870|**Entity**|
|10871|**Ongoing conversation (Deprecated)**|
|10872|**Live work item event**|
|10873|**Work Stream**|
|10874|**Masking Rule**|
|10875|**Auto block rule**|
|10876|**Bot Channel Registration Secret**|
|10877|**Omnichannel channel api conversation privilege**|
|10878|**Omnichannel channel api message privilege**|
|10879|**Channel api method mapping**|
|10880|**External context**|
|10881|**Flagged spam**|
|10882|**Language**|
|10883|**Conversation**|
|10886|**Context item value**|
|10887|**Live Work Item Participant (Deprecated)**|
|10888|**Conversation Sentiment**|
|10889|**Context variable**|
|10890|**Localization**|
|10891|**OC Payment Profile**|
|10892|**Recording**|
|10893|**Omnichannel Request**|
|10894|**Rich message**|
|10895|**Rich message map**|
|10896|**Rule Item**|
|10897|**Sentiment daily topic**|
|10898|**Sentiment daily topic keyword**|
|10899|**Sentiment daily topic trending**|
|10900|**Session**|
|10901|**Session Participant Event**|
|10902|**Session Sentiment**|
|10903|**Automated Message**|
|10904|**Tag**|
|10905|**Geo Location Provider**|
|10906|**Omnichannel Configuration**|
|10907|**Omnichannel Personalization**|
|10908|**Omnichannel Queue (Deprecated)**|
|10909|**Omnichannel Sync Config**|
|10910|**Operating Hour**|
|10911|**Personal quick reply**|
|10912|**Personal sound setting**|
|10913|**Persona Security Role Mapping**|
|10914|**Presence**|
|10915|**Provider**|
|10916|**RoutingRequest**|
|10917|**Search Configuration**|
|10918|**Sentiment analysis**|
|10919|**Session event**|
|10920|**Session participant**|
|10921|**Audio File**|
|10922|**Sound notification setting**|
|10923|**Transcript**|
|10924|**UR notification template**|
|10925|**UR Notification Template Mapping**|
|10926|**User settings**|
|10927|**Self service**|
|10934|**Agent capacity update history**|
|10935|**Bookable Resource Capacity Profile**|
|10936|**Contact Center Generated Rule**|
|10937|**Work stream capacity profile**|
|10938|**Conversation Capacity profile**|
|10939|**Agent Capacity Profile Unit**|
|10940|**Agent Channel State**|
|10941|**Agent Status**|
|10942|**Agent Group**|
|10943|**Agent Group Language**|
|10944|**Agent Group Matching Criteria**|
|10945|**Agent Group Membership**|
|10946|**Agent Group Region**|
|10947|**Agent Language**|
|10948|**Agent Matching Criteria**|
|10949|**Agent Region**|
|10950|**Language Hierarchy**|
|10951|**Matching Criteria**|
|10952|**Conversation Matching Criteria**|
|10953|**Queue User Group Membership**|
|10954|**Region**|
|10955|**Conversation Characteristic**|
|10956|**Session Characteristic**|
|10957|**Skill Attachment Rule**|
|10958|**Attach Skill**|
|10959|**Model training details**|
|10960|**Training data import configuration**|
|10961|**Characteristic mapping**|
|10962|**Training record**|
|10963|**Skill finder model**|
|10964|**Effort estimate**|
|10965|**Effort estimation model**|
|10966|**Effort model training details**|
|10967|**ConversationInsight**|
|10968|**CC Eventing Scenario**|
|10969|**CC Playbook Policy**|
|10970|**CC User Prompt**|
|10971|**promptmessagelocale**|
|10972|**promptmessagetemplate**|
|10973|**Active ICD Extension**|
|10974|**Entity-Workstream Map**|
|10975|**ICD Extension**|
|10976|**msdyn_broadcastmessagebulkactionapiprivilege**|
|10977|**msdyn_bulkassigntoqueueapiprivilege**|
|10978|**msdyn_bulkforcecloseapiprivilege**|
|10979|**Lock Status**|
|10980|**msdyn_notifyagentbulkactionapiprivilege**|
|10981|**Omnichannel agent assignment custom api privilege**|
|10982|**Bulk Action**|
|10983|**Conversation Action Item**|
|10984|**Conversation Aggregated Insights**|
|10985|**Comment**|
|10986|**Conversation Participant Insights**|
|10987|**Conversation Participant Sentiment**|
|10988|**Conversation Question**|
|10989|**Conversation Segment Sentiment**|
|10990|**Conversation Sentiment**|
|10991|**Conversation Signal**|
|10992|**Conversation Subject**|
|10993|**Conversation Summary Suggestion**|
|10994|**Conversation System Tag**|
|10995|**Conversation Tag**|
|10996|**Recording (Deprecated)**|
|10997|**SCI Conversation**|
|10998|**Custom Email Highlight**|
|10999|**Custom Highlight**|
|11000|**Custom Publisher**|
|11001|**EnvironmentSettings**|
|11002|**UserSettings**|
|11003|**Digital assets configuration**|
|11004|**File**|
|11005|**Tag**|
|11006|**Video**|
|11009|**CatalogEventStatusConfiguration**|
|11010|**Configuration**|
|11011|**Trigger**|
|11012|**Triggers To Sdk Message Processing Steps**|
|11013|**EventParameterMetadata**|
|11014|**TrackingContext**|
|11015|**Marketing feature configuration**|
|11016|**Consent Provider**|
|11017|**Consent provider Localization**|
|11018|**(Deprecated) Compliance**|
|11019|**(Deprecated) Compliance**|
|11020|**Compliance profile**|
|11021|**Consent**|
|11022|**CXP Consent Center Configuration**|
|11023|**Consent Provider Default Configuration**|
|11024|**Default purpose**|
|11025|**Submit Button**|
|11026|**Consent System Configuration**|
|11027|**(Deprecated) Contact Point Consent**|
|11028|**(Deprecated) Contact Point Consent**|
|11029|**(Deprecated) Contact Point Consent**|
|11030|**Contact Point Consent**|
|11031|**Contact Point Settings**|
|11032|**CXP Customer Data Mapping**|
|11033|**Customer Data Selection**|
|11034|**Preference Center**|
|11035|**Preference center link**|
|11036|**Purpose**|
|11037|**Topic**|
|11039|**msdynmkt_experimentv2**|
|11040|**ACS channel instance**|
|11041|**ACS channel instance account**|
|11042|**Infobip channel instance**|
|11043|**Infobip channel instance account**|
|11044|**Link mobility channel instance**|
|11045|**Link mobility channel instance account**|
|11046|**MockSmsProvider channel instance**|
|11047|**MockSmsProvider channel instance account**|
|11048|**TeleSign channel instance**|
|11049|**TeleSign channel instance account**|
|11050|**Twilio channel instance**|
|11051|**Twilio channel instance account**|
|11052|**Vibes channel instance**|
|11053|**Vibes channel instance account**|
|11054|**Predefined Placeholder**|
|11055|**Metadata Entity Relationship**|
|11056|**Metadata Item**|
|11057|**Metadata Store State**|
|11058|**DigitalSellingActiveTask**|
|11059|**DigitalSellingCompletedTask**|
|11060|**Sales Tag**|
|11061|**Sequence**|
|11062|**Sequence Stat**|
|11063|**Sequence Target**|
|11064|**Sequence Target Step**|
|11065|**Sequence Template**|
|11067|**sabackupdiagnostic**|
|11068|**SABatchRunInstance**|
|11069|**salesroutingdiagnostic**|
|11070|**SARunInstance**|
|11071|**Segment**|
|11072|**segmentsetting**|
|11073|**Segment property**|
|11074|**SegmentsUtil**|
|11075|**Assignment Rule**|
|11076|**Seller attribute**|
|11077|**Seller attribute value**|
|11078|**Assignment Map**|
|11079|**Sales Assignment Setting**|
|11080|**Sales routing run**|
|11082|**Extended User Setting**|
|11083|**Sales acceleration insights**|
|11084|**Sales Acceleration settings**|
|11085|**Insight**|
|11086|**Work List Suggestion**|
|11087|**Work list suggestion source**|
|11088|**Work List View Configuration**|
|11089|**Work Queue Record**|
|11090|**Work Queue Record State**|
|11091|**Work list user setting**|
|11092|**WQDataSource**|
|11093|**Suggestion Assignment Rule**|
|11094|**Suggestion Principal Object Access**|
|11095|**Suggestion Seller Priority**|
|11096|**Data Hygiene Setting Info**|
|11097|**Duplicate Detection Plugin Run**|
|11098|**Duplicate Lead Mapping**|
|11099|**Lead Hygiene Setting**|
|11100|**Linked Entity Attribute Validity**|
|11101|**Sales provisioning request**|
|11102|**SalesOmnichannel Message**|
|11103|**Text message template**|
|11104|**Data Analytics Admin Settings (Deprecated)**|
|11105|**Data Analytics Report**|
|11106|**Insights**|
|11107|**Sales acceleration reports**|
|11108|**Bot user mapping**|
|11110|**Bot Session**|
|11111|**Context Item Elastic**|
|11112|**Queue Extension**|
|11113|**Timeout Rule**|
|11114|**Automated action rules mapping**|
|11115|**Capacity Wrap Up Time**|
|11116|**Channel Profile**|
|11117|**Channel Profile Notification Template**|
|11118|**Channel Profile Survey Config**|
|11122|**Channel Instance Context Variable**|
|11123|**Common Channel Config**|
|11124|**Conversation Profile**|
|11125|**Profile Picker**|
|11126|**Agent Assist Bot Config**|
|11127|**Agent Assist Configuration**|
|11128|**Common transcript message**|
|11129|**Conversation Record**|
|11130|**Last message info**|
|11131|**Encrypted message setting**|
|11132|**Message masking rule**|
|11133|**ML Data Masking Rule**|
|11134|**Unredacted Note**|
|11135|**Action**|
|11136|**Agent Nudge**|
|11137|**Agent Nudge Template**|
|11138|**Compliance Rule**|
|11139|**Conversation Step**|
|11140|**EvaluationDetails**|
|11141|**EvaluationHistory**|
|11142|**Guardrail**|
|11143|**GuardrailVersion**|
|11144|**IndicatorQuestion**|
|11145|**Monitor**|
|11146|**MonitorAction**|
|11147|**MonitorNotificationConfig**|
|11148|**QINotificationConfig**|
|11149|**QINotificationConfigItem**|
|11150|**QualityIndicator**|
|11151|**QualityIndicatorVersion**|
|11152|**Contact Center Agent Skill Configuration**|
|11153|**Contact Center Agent Skill Setting**|
|11154|**Contact Center Workstream Skill**|
|11155|**Simulated Conversation**|
|11156|**Simulation Run**|
|11157|**msdyn_dataclassification**|
|11158|**msdyn_historicalqea**|
|11159|**msdyn_historicalqeabacklog**|
|11160|**simulationtracker**|
|11161|**msdyn_transformationjob**|
|11162|**msdyn_transformationjobdefinition**|
|11163|**msdyn_transformationjobtracker**|
|11164|**Transformation Transcript**|
|11165|**msdyn_admin_pin**|
|11166|**Conversation disposition code map**|
|11167|**Disposition Code Category**|
|11168|**Live Conversation Counter Condition**|
|11169|**OC Disposition Code**|
|11170|**msdyn_personal_pin**|
|11171|**Work Stream Bot Mapping**|
|11173|**Screen Recording**|
|11174|**ScreenRecordingLink**|
|11175|**Real Time Streaming Analytics KPI Definition**|
|11176|**Real Time Streaming Analytics Live Banner**|
|11177|**Real Time Streaming Analytics Live Banner Message**|
|11178|**Real Time Streaming Analytics Preference**|
|11179|**Real Time Streaming Analytics Report**|
|11180|**Real Time Streaming Analytics Report Page**|
|11181|**Real Time Streaming Analytics Threshold**|
|11182|**Representative Copilot Setting**|
|11183|**Agent Copilot Term**|
|11186|**Copilot Organization Workload**|
|11187|**copilot scenario setting**|
|11188|**Copilot Skill**|
|11189|**Copilot Skill Mapping**|
|11190|**Copilot Skill Role**|
|11191|**Copilot Starter Prompt**|
|11192|**Copilot Summarization Setting**|
|11193|**Copilot Tool**|
|11194|**Copilot User Workload**|
|11195|**Entity Copilot Configuration**|
|11196|**Organization Prompt**|
|11197|**msdyn_agentsetting**|
|11198|**msdyn_aiconnectormapping**|
|11199|**msdyn_businessprofile**|
|11200|**Evaluation Run Config**|
|11201|**intent**|
|11202|**intentattribute**|
|11203|**intentattributeset**|
|11204|**intentattribute_entity**|
|11205|**Intent Config**|
|11206|**Intent Context History**|
|11207|**Intent Core Evaluation Job**|
|11208|**intententity**|
|11209|**LOB Backfill Status**|
|11210|**Line of Business**|
|11211|**Intent Family Solution Map**|
|11212|**Intent Family Admin Assignment**|
|11213|**msdyn_intentfamily_harvestingconfiguration**|
|11214|**msdyn_intentfeature_configuration**|
|11215|**Intent Group Condition**|
|11216|**msdyn_intentharvesting_batchjobstatus**|
|11217|**msdyn_intentharvesting_batchjobstatusdetail**|
|11218|**Intent Harvesting Proposed Intent**|
|11219|**msdyn_intentharvesting_provisioning_status**|
|11220|**Intent Harvesting Runtime Result**|
|11221|**msdyn_intentmetrics**|
|11222|**msdyn_intentmetrics_aggregate**|
|11223|**msdyn_intentmetrics_jobdata**|
|11224|**Intent Playbook**|
|11225|**Intent playbook map**|
|11226|**Intent Solution Map**|
|11227|**msdyn_intentsolution_mappingconfiguration**|
|11228|**msdyn_nextbestactionsconfig**|
|11229|**msdyn_organizationsolutionmap**|
|11230|**Bulk Harvest Run Log**|
|11231|**Harvest Eligibility Condition**|
|11232|**Harvest Work Item**|
|11233|**msdyn_historicalcaseharvestbatch**|
|11234|**msdyn_historicalcaseharvestrun**|
|11235|**Historical Case Harvest Run Log**|
|11236|**Interim Update Knowledge Article**|
|11237|**Knowledge Article Custom Entity**|
|11238|**Knowledge Harvest Job Record**|
|11239|**Knowledge Harvest Plan**|
|11240|**Case Enrichment**|
|11241|**Case follow up and closure configuration**|
|11242|**Case sentiment settings**|
|11243|**Case Suggestion**|
|11244|**Case Suggestion Request Payload**|
|11245|**Case Suggestions Data Souce**|
|11246|**User Preference For Copilot**|
|11247|**Copilot assisted case form fill settings**|
|11248|**Copilot Event**|
|11249|**Copilot Interaction**|
|11250|**Copilot Interaction Data**|
|11251|**Copilot knowledge interaction**|
|11252|**Copilot Transcript**|
|11253|**Copilot Transcript Data**|
|11254|**KB Enrichment**|
|11255|**Knowledge Article Suggestion**|
|11256|**Knowledge Article Suggestion Data Source**|
|11257|**Next Action**|
|11258|**Service Copilot Plugin**|
|11259|**Service Copilot Plugin Action**|
|11260|**Service Copilot Plugin Role**|
|11261|**Suggestion Interaction**|
|11262|**Suggestion request payload**|
|11263|**Suggestions Model Summary**|
|11264|**Suggestions Setting**|
|11265|**AI Simulation Result**|
|11266|**AI Simulation Run**|
|11267|**Agent Source**|
|11268|**AI Agent Status**|
|11269|**Case Management Agent for case closure Activity**|
|11270|**Case Management Agent for case closure Monitoring**|
|11271|**Email Template Configuration**|
|11272|**msdyn_caseaiprediction**|
|11273|**Evaluation**|
|11274|**Evaluation category**|
|11275|**Evaluation criteria**|
|11276|**Evaluation criteria version**|
|11277|**Evaluation Entity Config**|
|11278|**Evaluation Extension**|
|11279|**Evaluation Global Config**|
|11280|**Evaluation input config**|
|11281|**Evaluation localized content**|
|11282|**Evaluation Notification Configuration**|
|11283|**Evaluation Plan**|
|11284|**Evaluation Plan Batch**|
|11285|**Evaluation Plan Ontrigger Backlog**|
|11286|**Evaluation Plan Run**|
|11287|**Evaluation question**|
|11288|**Evaluation Trigger Config**|
|11289|**Criteria Simulation**|
|11290|**PA Flow Run Tracker**|
|11291|**Agent Coach Admin Settings**|
|11292|**Agent Coach Playbook**|
|11293|**Agent Coach Playbook Instructions**|
|11294|**Agent Coach Policy Settings**|
|11295|**Case Coaching Result**|
|11296|**Email Coaching Result**|
|11297|**Data Analytics User Customized Report**|
|11298|**Data Analytics Dataset**|
|11299|**Data Analytics Workspace**|
|11300|**Report Bookmark**|
|11301|**Agent Resource Forecasting**|
|11302|**[Deprecated] Dynamics Customer Service Analytics**|
|11303|**Case Topic**|
|11304|**Case Topic Setting**|
|11305|**Case Topic Summary**|
|11306|**Case topic Incident mapping**|
|11307|**Case Management Agent analytics**|
|11308|**Customer Service historical analytics**|
|11309|**Email analytics**|
|11310|**Forecast**|
|11311|**Knowledge analytics**|
|11312|**Model Customization analytics**|
|11313|**Quality Evaluation Agent analytics**|
|11314|**Real-time analytics for record routing**|
|11315|**Forecast Summary and Setting**|
|11316|**Keywords Description Suggestion Setting**|
|11317|**Bot Variable**|
|11318|**Conversation Summary Interaction**|
|11319|**Conversation Summary Setting**|
|11320|**Conversation Topic**|
|11321|**Conversation Topic Setting**|
|11322|**Conversation Topic Summary**|
|11323|**Conversation topic Conversation mapping**|
|11324|**Omnichannel historical analytics**|
|11325|**Contact Center historical analytics**|
|11326|**Omnichannel voice historical analytics (preview) (Deprecated)**|
|11327|**Omnichannel Realtime analytics**|
|11328|**Copilot Analytics**|
|11329|**Conversation Analytic**|
|11330|**Session Analytics**|
|11331|**Session Participant Analytic**|
|11332|**Sales Research Manager**|
|11333|**Engage And Readiness Agent Result V2**|
|11334|**SalesAgentConfigurationV2**|
|11335|**SalesAgentExecutionConfig**|
|11336|**Sales Agent Handover**|
|11337|**Sales agent processing state**|
|11338|**SalesAgentProfile**|
|11339|**Sales agent run**|
|11340|**Trigger Sales Agent**|
|11341|**Account Research Agent Trigger**|
|11342|**Account Research Result**|
|11343|**Account Research Summary Trigger**|
|11344|**Always Run SQA Segment**|
|11345|**Competitor Research Agent Trigger**|
|11346|**Custom Account Insights Result**|
|11347|**Customization Agent Trigger**|
|11348|**Custom OOB Research Result**|
|11349|**Summary Synthesizer Input**|
|11350|**summarysynthesizeroutput (Deprecated)**|
|11351|**Lead Agent Result**|
|11352|**Lead Delink Result**|
|11353|**Lead Email Extension**|
|11354|**Default OOB Account Research Result**|
|11355|**Outreach Agent Result**|
|11356|**Outreach Trigger Agent**|
|11357|**Qualification Agent Trigger**|
|11358|**Sales Agent Configuration**|
|11359|**SalesAgentUsage**|
|11360|**Sales Company Resolver Lead Trigger**|
|11361|**Stakeholder Research Output**|
|11362|**Summary Synthesizer Output**|
|11363|**Summary Synthesizer Agent Trigger**|
|11364|**Target Customer Profile Prefill Agent Result**|
|11365|**TargetCustomerProfilePrefillAgentTrigger**|
|11366|**Web Research Agent Trigger**|
|11367|**Engage And Readiness Agent Result**|
|11368|**SCA Engage Agent Result**|
|11369|**Opportunity Account Research Result**|
|11370|**Opportunity Competitor Research Result Cache**|
|11371|**Opportunity Ranker Mapping**|
|11372|**Opportunity Research Agent Trigger**|
|11373|**Opportunity Research Indicator**|
|11374|**Opportunity Research Result**|
|11375|**Opportunity Research User Interactions**|
|11376|**RCS Watermark**|
|11377|**Related Conversation Trigger Table**|
|11378|**SOA Similar Opportunities**|
|11379|**Data quality log**|
|11380|**Data quality reassignment**|
|11381|**Data quality source**|
|11382|**Data quality suggestion**|
|11383|**DQA Ranker Trigger**|
|11384|**Prioritized Action Catalogue**|
|11385|**rawactioncatalogue**|
|11386|**Recommended Action Derived Insights**|
|11387|**Recommended Action Pull Watermark**|
|11388|**recommendedactionrundetails**|
|11389|**msdyn_recommendedactionsourceagentconfig**|
|11390|**contactprofilerdetail**|
|11391|**contactprofilerresult**|
|11392|**msdyn_governanceagent_status**|
|11393|**msdyn_guardrail_consumer_mapping**|
|11394|**msdyn_guardrail_execution_event**|
|11395|**msdyn_guardrail_execution_info**|
|11396|**msdyn_guardrail_rule**|
|11397|**msdyn_guardrail_rule_version**|
|11398|**msdyn_guardrail_scenariotype**|
|11399|**Email thread**|
|11400|**msdyn_aidescoptimizationrun**|
|11401|**msdyn_aidescriptioncandidate**|
|11402|**msdyn_aidescriptionpublishjob**|
|11403|**msdyn_aidescriptionrun**|
|11404|**msdyn_aidescriptionsettings**|
|11405|**msdyn_aidescriptionvalue**|

## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [bulkoperation_sla_slaid](#BKMK_bulkoperation_sla_slaid)
- [bulkoperation_sla_slainvokedid](#BKMK_bulkoperation_sla_slainvokedid)
- [campaignactivity_sla_slaid](#BKMK_campaignactivity_sla_slaid)
- [campaignactivity_sla_slainvokedid](#BKMK_campaignactivity_sla_slainvokedid)
- [campaignresponse_sla_slaid](#BKMK_campaignresponse_sla_slaid)
- [campaignresponse_sla_slainvokedid](#BKMK_campaignresponse_sla_slainvokedid)
- [incidentresolution_sla_slaid](#BKMK_incidentresolution_sla_slaid)
- [incidentresolution_sla_slainvokedid](#BKMK_incidentresolution_sla_slainvokedid)
- [manualsla_cases](#BKMK_manualsla_cases)
- [manualsla_invoice](#BKMK_manualsla_invoice)
- [manualsla_lead](#BKMK_manualsla_lead)
- [manualsla_msdyn_aiagentstatus](#BKMK_manualsla_msdyn_aiagentstatus)
- [manualsla_opportunity](#BKMK_manualsla_opportunity)
- [manualsla_quote](#BKMK_manualsla_quote)
- [manualsla_salesorder](#BKMK_manualsla_salesorder)
- [manualsla_serviceappointment](#BKMK_manualsla_serviceappointment)
- [msdyn_copilottranscript_sla_slaid](#BKMK_msdyn_copilottranscript_sla_slaid)
- [msdyn_copilottranscript_sla_slainvokedid](#BKMK_msdyn_copilottranscript_sla_slainvokedid)
- [msdyn_migrationtracker_LegacySLA_sla](#BKMK_msdyn_migrationtracker_LegacySLA_sla)
- [msdyn_migrationtracker_ModernSLA_sla](#BKMK_msdyn_migrationtracker_ModernSLA_sla)
- [msdyn_ocliveworkitem_sla_slaid](#BKMK_msdyn_ocliveworkitem_sla_slaid)
- [msdyn_ocliveworkitem_sla_slainvokedid](#BKMK_msdyn_ocliveworkitem_sla_slainvokedid)
- [msdyn_ocsession_sla_slaid](#BKMK_msdyn_ocsession_sla_slaid)
- [msdyn_ocsession_sla_slainvokedid](#BKMK_msdyn_ocsession_sla_slainvokedid)
- [msfp_alert_sla_slaid](#BKMK_msfp_alert_sla_slaid)
- [msfp_alert_sla_slainvokedid](#BKMK_msfp_alert_sla_slainvokedid)
- [msfp_surveyinvite_sla_slaid](#BKMK_msfp_surveyinvite_sla_slaid)
- [msfp_surveyinvite_sla_slainvokedid](#BKMK_msfp_surveyinvite_sla_slainvokedid)
- [msfp_surveyresponse_sla_slaid](#BKMK_msfp_surveyresponse_sla_slaid)
- [msfp_surveyresponse_sla_slainvokedid](#BKMK_msfp_surveyresponse_sla_slainvokedid)
- [opportunityclose_sla_slaid](#BKMK_opportunityclose_sla_slaid)
- [opportunityclose_sla_slainvokedid](#BKMK_opportunityclose_sla_slainvokedid)
- [orderclose_sla_slaid](#BKMK_orderclose_sla_slaid)
- [orderclose_sla_slainvokedid](#BKMK_orderclose_sla_slainvokedid)
- [quoteclose_sla_slaid](#BKMK_quoteclose_sla_slaid)
- [quoteclose_sla_slainvokedid](#BKMK_quoteclose_sla_slainvokedid)
- [sla_cases](#BKMK_sla_cases)
- [sla_entitlement](#BKMK_sla_entitlement)
- [sla_entitlementtemplate](#BKMK_sla_entitlementtemplate)
- [sla_invoice](#BKMK_sla_invoice)
- [sla_lead](#BKMK_sla_lead)
- [sla_msdyn_aiagentstatus](#BKMK_sla_msdyn_aiagentstatus)
- [sla_opportunity](#BKMK_sla_opportunity)
- [sla_quote](#BKMK_sla_quote)
- [sla_salesorder](#BKMK_sla_salesorder)
- [sla_serviceappointment](#BKMK_sla_serviceappointment)

### <a name="BKMK_bulkoperation_sla_slaid"></a> bulkoperation_sla_slaid

Many-To-One Relationship: [bulkoperation bulkoperation_sla_slaid](bulkoperation.md#BKMK_bulkoperation_sla_slaid)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkoperation`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`bulkoperation_sla_slaid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10001<br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_bulkoperation_sla_slainvokedid"></a> bulkoperation_sla_slainvokedid

Many-To-One Relationship: [bulkoperation bulkoperation_sla_slainvokedid](bulkoperation.md#BKMK_bulkoperation_sla_slainvokedid)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkoperation`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`bulkoperation_sla_slainvokedid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaignactivity_sla_slaid"></a> campaignactivity_sla_slaid

Many-To-One Relationship: [campaignactivity campaignactivity_sla_slaid](campaignactivity.md#BKMK_campaignactivity_sla_slaid)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignactivity`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`campaignactivity_sla_slaid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10001<br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_campaignactivity_sla_slainvokedid"></a> campaignactivity_sla_slainvokedid

Many-To-One Relationship: [campaignactivity campaignactivity_sla_slainvokedid](campaignactivity.md#BKMK_campaignactivity_sla_slainvokedid)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignactivity`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`campaignactivity_sla_slainvokedid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaignresponse_sla_slaid"></a> campaignresponse_sla_slaid

Many-To-One Relationship: [campaignresponse campaignresponse_sla_slaid](campaignresponse.md#BKMK_campaignresponse_sla_slaid)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignresponse`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`campaignresponse_sla_slaid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10001<br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_campaignresponse_sla_slainvokedid"></a> campaignresponse_sla_slainvokedid

Many-To-One Relationship: [campaignresponse campaignresponse_sla_slainvokedid](campaignresponse.md#BKMK_campaignresponse_sla_slainvokedid)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignresponse`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`campaignresponse_sla_slainvokedid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_incidentresolution_sla_slaid"></a> incidentresolution_sla_slaid

Many-To-One Relationship: [incidentresolution incidentresolution_sla_slaid](incidentresolution.md#BKMK_incidentresolution_sla_slaid)

|Property|Value|
|---|---|
|ReferencingEntity|`incidentresolution`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`incidentresolution_sla_slaid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10001<br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_incidentresolution_sla_slainvokedid"></a> incidentresolution_sla_slainvokedid

Many-To-One Relationship: [incidentresolution incidentresolution_sla_slainvokedid](incidentresolution.md#BKMK_incidentresolution_sla_slainvokedid)

|Property|Value|
|---|---|
|ReferencingEntity|`incidentresolution`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`incidentresolution_sla_slainvokedid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_manualsla_cases"></a> manualsla_cases

Many-To-One Relationship: [incident manualsla_cases](incident.md#BKMK_manualsla_cases)

|Property|Value|
|---|---|
|ReferencingEntity|`incident`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`manualsla_cases`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `72210bbb-d9d5-42df-8efd-39395a3cd7a7`|

### <a name="BKMK_manualsla_invoice"></a> manualsla_invoice

Many-To-One Relationship: [invoice manualsla_invoice](invoice.md#BKMK_manualsla_invoice)

|Property|Value|
|---|---|
|ReferencingEntity|`invoice`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`manualsla_invoice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `a84eb3ff-6dc5-4f57-bbf0-7b664c11fb62`|

### <a name="BKMK_manualsla_lead"></a> manualsla_lead

Many-To-One Relationship: [lead manualsla_lead](lead.md#BKMK_manualsla_lead)

|Property|Value|
|---|---|
|ReferencingEntity|`lead`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`manualsla_lead`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `f7ba26ee-3f8e-4cf2-8e02-0b4bbcd16da8`|

### <a name="BKMK_manualsla_msdyn_aiagentstatus"></a> manualsla_msdyn_aiagentstatus

Many-To-One Relationship: [msdyn_aiagentstatus manualsla_msdyn_aiagentstatus](msdyn_aiagentstatus.md#BKMK_manualsla_msdyn_aiagentstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_aiagentstatus`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`manualsla_msdyn_aiagentstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_manualsla_opportunity"></a> manualsla_opportunity

Many-To-One Relationship: [opportunity manualsla_opportunity](opportunity.md#BKMK_manualsla_opportunity)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunity`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`manualsla_opportunity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-00aa-000010001203`|

### <a name="BKMK_manualsla_quote"></a> manualsla_quote

Many-To-One Relationship: [quote manualsla_quote](quote.md#BKMK_manualsla_quote)

|Property|Value|
|---|---|
|ReferencingEntity|`quote`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`manualsla_quote`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `642095db-91dd-4813-bb31-665a3a2bae61`|

### <a name="BKMK_manualsla_salesorder"></a> manualsla_salesorder

Many-To-One Relationship: [salesorder manualsla_salesorder](salesorder.md#BKMK_manualsla_salesorder)

|Property|Value|
|---|---|
|ReferencingEntity|`salesorder`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`manualsla_salesorder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `71f7da6e-2772-4097-89d1-3670ff8348bb`|

### <a name="BKMK_manualsla_serviceappointment"></a> manualsla_serviceappointment

Many-To-One Relationship: [serviceappointment manualsla_serviceappointment](serviceappointment.md#BKMK_manualsla_serviceappointment)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`manualsla_serviceappointment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `70540b32-fc70-426e-a4b3-a92056ce4717`|

### <a name="BKMK_msdyn_copilottranscript_sla_slaid"></a> msdyn_copilottranscript_sla_slaid

Many-To-One Relationship: [msdyn_copilottranscript msdyn_copilottranscript_sla_slaid](msdyn_copilottranscript.md#BKMK_msdyn_copilottranscript_sla_slaid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`msdyn_copilottranscript_sla_slaid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10001<br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_msdyn_copilottranscript_sla_slainvokedid"></a> msdyn_copilottranscript_sla_slainvokedid

Many-To-One Relationship: [msdyn_copilottranscript msdyn_copilottranscript_sla_slainvokedid](msdyn_copilottranscript.md#BKMK_msdyn_copilottranscript_sla_slainvokedid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`msdyn_copilottranscript_sla_slainvokedid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_migrationtracker_LegacySLA_sla"></a> msdyn_migrationtracker_LegacySLA_sla

Many-To-One Relationship: [msdyn_migrationtracker msdyn_migrationtracker_LegacySLA_sla](msdyn_migrationtracker.md#BKMK_msdyn_migrationtracker_LegacySLA_sla)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_migrationtracker`|
|ReferencingAttribute|`msdyn_legacyslaid`|
|ReferencedEntityNavigationPropertyName|`msdyn_migrationtracker_LegacySLA_sla`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_migrationtracker_ModernSLA_sla"></a> msdyn_migrationtracker_ModernSLA_sla

Many-To-One Relationship: [msdyn_migrationtracker msdyn_migrationtracker_ModernSLA_sla](msdyn_migrationtracker.md#BKMK_msdyn_migrationtracker_ModernSLA_sla)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_migrationtracker`|
|ReferencingAttribute|`msdyn_modernslaid`|
|ReferencedEntityNavigationPropertyName|`msdyn_migrationtracker_ModernSLA_sla`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocliveworkitem_sla_slaid"></a> msdyn_ocliveworkitem_sla_slaid

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_ocliveworkitem_sla_slaid](msdyn_ocliveworkitem.md#BKMK_msdyn_ocliveworkitem_sla_slaid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocliveworkitem_sla_slaid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10001<br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_msdyn_ocliveworkitem_sla_slainvokedid"></a> msdyn_ocliveworkitem_sla_slainvokedid

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_ocliveworkitem_sla_slainvokedid](msdyn_ocliveworkitem.md#BKMK_msdyn_ocliveworkitem_sla_slainvokedid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocliveworkitem_sla_slainvokedid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsession_sla_slaid"></a> msdyn_ocsession_sla_slaid

Many-To-One Relationship: [msdyn_ocsession msdyn_ocsession_sla_slaid](msdyn_ocsession.md#BKMK_msdyn_ocsession_sla_slaid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsession_sla_slaid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10001<br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_msdyn_ocsession_sla_slainvokedid"></a> msdyn_ocsession_sla_slainvokedid

Many-To-One Relationship: [msdyn_ocsession msdyn_ocsession_sla_slainvokedid](msdyn_ocsession.md#BKMK_msdyn_ocsession_sla_slainvokedid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsession_sla_slainvokedid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msfp_alert_sla_slaid"></a> msfp_alert_sla_slaid

Many-To-One Relationship: [msfp_alert msfp_alert_sla_slaid](msfp_alert.md#BKMK_msfp_alert_sla_slaid)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`msfp_alert_sla_slaid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10001<br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_msfp_alert_sla_slainvokedid"></a> msfp_alert_sla_slainvokedid

Many-To-One Relationship: [msfp_alert msfp_alert_sla_slainvokedid](msfp_alert.md#BKMK_msfp_alert_sla_slainvokedid)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`msfp_alert_sla_slainvokedid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msfp_surveyinvite_sla_slaid"></a> msfp_surveyinvite_sla_slaid

Many-To-One Relationship: [msfp_surveyinvite msfp_surveyinvite_sla_slaid](msfp_surveyinvite.md#BKMK_msfp_surveyinvite_sla_slaid)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`msfp_surveyinvite_sla_slaid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10001<br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_msfp_surveyinvite_sla_slainvokedid"></a> msfp_surveyinvite_sla_slainvokedid

Many-To-One Relationship: [msfp_surveyinvite msfp_surveyinvite_sla_slainvokedid](msfp_surveyinvite.md#BKMK_msfp_surveyinvite_sla_slainvokedid)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`msfp_surveyinvite_sla_slainvokedid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msfp_surveyresponse_sla_slaid"></a> msfp_surveyresponse_sla_slaid

Many-To-One Relationship: [msfp_surveyresponse msfp_surveyresponse_sla_slaid](msfp_surveyresponse.md#BKMK_msfp_surveyresponse_sla_slaid)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`msfp_surveyresponse_sla_slaid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10001<br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_msfp_surveyresponse_sla_slainvokedid"></a> msfp_surveyresponse_sla_slainvokedid

Many-To-One Relationship: [msfp_surveyresponse msfp_surveyresponse_sla_slainvokedid](msfp_surveyresponse.md#BKMK_msfp_surveyresponse_sla_slainvokedid)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`msfp_surveyresponse_sla_slainvokedid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_opportunityclose_sla_slaid"></a> opportunityclose_sla_slaid

Many-To-One Relationship: [opportunityclose opportunityclose_sla_slaid](opportunityclose.md#BKMK_opportunityclose_sla_slaid)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunityclose`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`opportunityclose_sla_slaid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10001<br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_opportunityclose_sla_slainvokedid"></a> opportunityclose_sla_slainvokedid

Many-To-One Relationship: [opportunityclose opportunityclose_sla_slainvokedid](opportunityclose.md#BKMK_opportunityclose_sla_slainvokedid)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunityclose`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`opportunityclose_sla_slainvokedid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_orderclose_sla_slaid"></a> orderclose_sla_slaid

Many-To-One Relationship: [orderclose orderclose_sla_slaid](orderclose.md#BKMK_orderclose_sla_slaid)

|Property|Value|
|---|---|
|ReferencingEntity|`orderclose`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`orderclose_sla_slaid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10001<br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_orderclose_sla_slainvokedid"></a> orderclose_sla_slainvokedid

Many-To-One Relationship: [orderclose orderclose_sla_slainvokedid](orderclose.md#BKMK_orderclose_sla_slainvokedid)

|Property|Value|
|---|---|
|ReferencingEntity|`orderclose`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`orderclose_sla_slainvokedid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_quoteclose_sla_slaid"></a> quoteclose_sla_slaid

Many-To-One Relationship: [quoteclose quoteclose_sla_slaid](quoteclose.md#BKMK_quoteclose_sla_slaid)

|Property|Value|
|---|---|
|ReferencingEntity|`quoteclose`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`quoteclose_sla_slaid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10001<br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_quoteclose_sla_slainvokedid"></a> quoteclose_sla_slainvokedid

Many-To-One Relationship: [quoteclose quoteclose_sla_slainvokedid](quoteclose.md#BKMK_quoteclose_sla_slainvokedid)

|Property|Value|
|---|---|
|ReferencingEntity|`quoteclose`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`quoteclose_sla_slainvokedid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sla_cases"></a> sla_cases

Many-To-One Relationship: [incident sla_cases](incident.md#BKMK_sla_cases)

|Property|Value|
|---|---|
|ReferencingEntity|`incident`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`sla_cases`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sla_entitlement"></a> sla_entitlement

Many-To-One Relationship: [entitlement sla_entitlement](entitlement.md#BKMK_sla_entitlement)

|Property|Value|
|---|---|
|ReferencingEntity|`entitlement`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`sla_entitlement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `e800e964-32d6-4024-bcea-2df605b0e762`|

### <a name="BKMK_sla_entitlementtemplate"></a> sla_entitlementtemplate

Many-To-One Relationship: [entitlementtemplate sla_entitlementtemplate](entitlementtemplate.md#BKMK_sla_entitlementtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`entitlementtemplate`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`sla_entitlementtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sla_invoice"></a> sla_invoice

Many-To-One Relationship: [invoice sla_invoice](invoice.md#BKMK_sla_invoice)

|Property|Value|
|---|---|
|ReferencingEntity|`invoice`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`sla_invoice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sla_lead"></a> sla_lead

Many-To-One Relationship: [lead sla_lead](lead.md#BKMK_sla_lead)

|Property|Value|
|---|---|
|ReferencingEntity|`lead`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`sla_lead`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sla_msdyn_aiagentstatus"></a> sla_msdyn_aiagentstatus

Many-To-One Relationship: [msdyn_aiagentstatus sla_msdyn_aiagentstatus](msdyn_aiagentstatus.md#BKMK_sla_msdyn_aiagentstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_aiagentstatus`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`sla_msdyn_aiagentstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sla_opportunity"></a> sla_opportunity

Many-To-One Relationship: [opportunity sla_opportunity](opportunity.md#BKMK_sla_opportunity)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunity`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`sla_opportunity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sla_quote"></a> sla_quote

Many-To-One Relationship: [quote sla_quote](quote.md#BKMK_sla_quote)

|Property|Value|
|---|---|
|ReferencingEntity|`quote`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`sla_quote`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sla_salesorder"></a> sla_salesorder

Many-To-One Relationship: [salesorder sla_salesorder](salesorder.md#BKMK_sla_salesorder)

|Property|Value|
|---|---|
|ReferencingEntity|`salesorder`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`sla_salesorder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sla_serviceappointment"></a> sla_serviceappointment

Many-To-One Relationship: [serviceappointment sla_serviceappointment](serviceappointment.md#BKMK_sla_serviceappointment)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`sla_serviceappointment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.sla?displayProperty=fullName>
