---
title: "SLA table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the SLA table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# SLA table/entity reference (Microsoft Dynamics 365 Customer Service)

Contains information about the tracked service-level KPIs for cases that belong to different customers.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service SLA table extends the [Microsoft Dynamics 365 SLA table](/dynamics365/developer/reference/entities/sla).



## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_ObjectTypeCode"></a> ObjectTypeCode

Changes from [ObjectTypeCode (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/sla#BKMK_ObjectTypeCode)

#### ObjectTypeCode Choices/Options

|Value|Label|
|---|---|
|10088|**Business Process**|
|10089|**Credential**|
|10090|**Desktop Flow Module**|
|10091|**Flow Capacity Assignment**|
|10092|**Flow Credential Application**|
|10093|**Flow Event**|
|10094|**Flow Machine**|
|10095|**Flow Machine Group**|
|10096|**Flow Machine Image**|
|10097|**Flow Machine Image Version**|
|10098|**Flow Machine Network**|
|10099|**ProcessStageParameter**|
|10100|**Saving Rule**|
|10101|**Tag**|
|10102|**Tagged Flow Session**|
|10103|**Tagged Process**|
|10104|**Workflow Metadata**|
|10105|**Work Queue**|
|10106|**Work Queue Item**|
|10107|**Desktop Flow Binary**|
|10108|**Flow Aggregation**|
|10109|**Flow Log**|
|10110|**Flow Run**|
|10111|**Approval Process**|
|10112|**Approval Stage Approval**|
|10113|**Approval Stage Condition**|
|10114|**Approval Stage Order**|
|10115|**Action Approval Model**|
|10116|**Approval**|
|10117|**Approval Request**|
|10118|**Approval Response**|
|10119|**Approval Step**|
|10120|**Await All Action Approval Model**|
|10121|**Await All Approval Model**|
|10122|**Basic Approval Model Data**|
|10123|**Flow Approval**|
|10132|**Connection Reference**|
|10133|**UnstructuredFileSearchEntity**|
|10134|**UnstructuredFileSearchRecord**|
|10135|**DVFileSearch**|
|10136|**DVFileSearchAttribute**|
|10137|**DVFileSearchEntity**|
|10138|**DVTableSearch**|
|10139|**DVTableSearchAttribute**|
|10140|**DVTableSearchEntity**|
|10141|**AICopilot**|
|10142|**AIPluginAuth**|
|10143|**AI Plugin Conversation Starter**|
|10144|**AI Plugin Conversation Starter Mapping**|
|10145|**AI Plugin Governance**|
|10146|**AI Plugin Governance Extended**|
|10147|**AIPluginOperationResponseTemplate**|
|10148|**AIPluginTitle**|
|10149|**SideloadedAIPlugin**|
|10150|**AIPlugin**|
|10151|**AIPluginExternalSchema**|
|10152|**AIPluginExternalSchemaProperty**|
|10153|**AIPluginInstance**|
|10154|**AIPluginOperation**|
|10155|**AIPluginOperationParameter**|
|10156|**AIPluginUserSetting**|
|10158|**Data Processing Event**|
|10159|**AI Event**|
|10160|**AI Model Catalog**|
|10161|**AI Builder Feedback Loop**|
|10162|**AI Form Processing Document**|
|10163|**AI Object Detection Image**|
|10164|**AI Object Detection Label**|
|10165|**AI Object Detection Bounding Box**|
|10166|**AI Object Detection Image Mapping**|
|10168|**AI Builder Dataset**|
|10169|**AI Builder Dataset File**|
|10170|**AI Builder Dataset Record**|
|10171|**AI Builder Datasets Container**|
|10172|**AI Builder File**|
|10173|**AI Builder File Attached Data**|
|10174|**AI Evaluation Configuration**|
|10175|**AI Evaluation Run**|
|10176|**AI Test Case**|
|10177|**AI Test Case Document**|
|10178|**AI Test Case Input**|
|10179|**AI Test Run**|
|10180|**AI Test Run Batch**|
|10181|**Help Page**|
|10182|**Tour**|
|10183|**BotContent**|
|10184|**ConversationTranscript**|
|10185|**Copilot**|
|10186|**Copilot component**|
|10187|**Copilot component collection**|
|10198|**Comment**|
|10199|**Governance Configuration**|
|10200|**Fabric AISkill**|
|10201|**App Insights Metadata**|
|10202|**Dataflow Connection Reference**|
|10203|**Schedule**|
|10204|**Dataflow Template**|
|10205|**Dataflow DatalakeFolder**|
|10206|**Data Movement Service Request**|
|10207|**Data Movement Service Request Status**|
|10208|**DMS Sync Request**|
|10209|**DMS Sync Status**|
|10210|**Knowledge Asset Configuration**|
|10211|**Module Run Detail**|
|10212|**QnA**|
|10213|**Salesforce Structured Object**|
|10214|**Salesforce Structured QnA Config**|
|10215|**Workflow Action Status**|
|10216|**FederatedKnowledgeCitation**|
|10217|**FederatedKnowledgeConfiguration**|
|10218|**FederatedKnowledgeEntityConfiguration**|
|10219|**FederatedKnowledgeMetadataRefresh**|
|10220|**Form Mapping**|
|10221|**Copilot Interactions**|
|10222|**PDF Setting**|
|10223|**Activity File Attachment**|
|10224|**Teams chat**|
|10225|**Service Configuration**|
|10226|**SLA KPI**|
|10227|**Integrated search provider**|
|10228|**Knowledge Management Setting**|
|10229|**Knowledge Federated Article**|
|10230|**Knowledge Federated Article Incident**|
|10231|**Search provider**|
|10232|**Knowledge Article Image**|
|10233|**Knowledge Configuration**|
|10234|**Knowledge Interaction Insight**|
|10235|**Knowledge Search Insight**|
|10236|**Favorite knowledge article**|
|10237|**Knowledge article language setting**|
|10238|**Knowledge Article Attachment**|
|10239|**Knowledge personalization**|
|10240|**Knowledge Article Template**|
|10241|**Knowledge search personal filter config**|
|10242|**Knowledge search filter**|
|10244|**Entity Cluster Configuration**|
|10245|**SupportUserTable**|
|10246|**FxExpression**|
|10247|**Function**|
|10248|**Plug-in**|
|10249|**PowerfxRule**|
|10250|**Planner Business Scenario**|
|10251|**Planner Sync Action**|
|10252|**Sensitivity Label**|
|10253|**Email Address Configuration**|
|10254|**Ms Graph Resource To Subscription**|
|10255|**Virtual Entity  Metadata**|
|10256|**Background Operation**|
|10257|**Report Parameter**|
|10258|**MobileOfflineProfileExtension**|
|10259|**MobileOfflineProfileItemFilter**|
|10260|**TeamMobileOfflineProfileMembership**|
|10261|**UserMobileOfflineProfileMembership**|
|10262|**OrganizationDataSyncSubscription**|
|10263|**OrganizationDataSyncSubscriptionEntity**|
|10264|**OrganizationDataSyncSubscriptionFnoTable**|
|10265|**OrganizationDataSyncFnoState**|
|10266|**OrganizationDataSyncState**|
|10267|**ArchiveCleanupInfo**|
|10268|**ArchiveCleanupOperation**|
|10269|**BulkArchiveConfig**|
|10270|**BulkArchiveFailureDetail**|
|10271|**BulkArchiveOperation**|
|10272|**BulkArchiveOperationDetail**|
|10273|**EnableArchivalRequest**|
|10274|**MetadataForArchival**|
|10275|**ReconciliationEntityInfo**|
|10276|**ReconciliationEntityStepInfo**|
|10277|**ReconciliationInfo**|
|10278|**RetentionCleanupInfo**|
|10279|**RetentionCleanupOperation**|
|10280|**RetentionConfig**|
|10281|**RetentionFailureDetail**|
|10282|**RetentionOperation**|
|10283|**RetentionOperationDetail**|
|10284|**RetentionSuccessDetail**|
|10285|**CertificateCredential**|
|10286|**Notification**|
|10287|**User Rating**|
|10288|**Mobile App**|
|10289|**Insights Store Data Source**|
|10290|**Insights Store Virtual Entity**|
|10291|**RoleEditorLayout**|
|10292|**Deleted Record Reference**|
|10293|**Restore Deleted Records Configuration**|
|10294|**App Action**|
|10295|**App Action Migration**|
|10296|**App Action Rule**|
|10299|**Card**|
|10300|**Card State Item**|
|10303|**Entity link chat configuration**|
|10304|**SharePoint Managed Identity**|
|10305|**AI Insight Card**|
|10306|**AI Skill Config**|
|10307|**Data Workspace**|
|10308|**Plan**|
|10309|**Plan Artifact**|
|10310|**Plan Attachment**|
|10311|**Rich Text Attachment**|
|10312|**Custom Control Extended Setting**|
|10313|**Timeline Pin**|
|10314|**Virtual Connector Data Source**|
|10315|**Virtual Table Column Candidate**|
|10317|**PM Analysis History**|
|10318|**PM Business Rule Automation Config**|
|10319|**PM Calendar**|
|10320|**PM Calendar Version**|
|10321|**PM Inferred Task**|
|10322|**PM Process Extended Metadata Version**|
|10323|**PM Process Template**|
|10324|**PM Process User Settings**|
|10325|**PM Process Version**|
|10326|**PM Recording**|
|10327|**PM Simulation**|
|10328|**PM Template**|
|10329|**PM View**|
|10330|**Analysis Component**|
|10331|**Analysis Job**|
|10332|**Analysis Override**|
|10333|**Analysis Result**|
|10334|**Analysis Result Detail**|
|10335|**Solution Health Rule**|
|10336|**Solution Health Rule Argument**|
|10337|**Solution Health Rule Set**|
|10338|**File Upload**|
|10339|**MainFewShot**|
|10340|**MakerFewShot**|
|10341|**SearchAttributeSettings**|
|10342|**SearchCustomAnalyzer**|
|10343|**SearchRelationshipSettings**|
|10344|**SearchResultsCache**|
|10345|**Search Telemetry**|
|10346|**TextDataRecordsIndexingStatus**|
|10347|**ViewAsExampleQuestion**|
|10348|**CopilotExampleQuestion**|
|10349|**CopilotGlossaryTerm**|
|10350|**CopilotSynonyms**|
|10351|**Site Component**|
|10352|**Site**|
|10353|**Site Language**|
|10354|**Power Pages Site Published**|
|10357|**External Identity**|
|10358|**Invitation**|
|10359|**Invite Redemption**|
|10360|**Portal Comment**|
|10361|**Setting**|
|10362|**Multistep Form Session**|
|10366|**Ad Placement**|
|10367|**Column Permission**|
|10368|**Column Permission Profile**|
|10369|**Content Snippet**|
|10370|**Basic Form**|
|10371|**Basic Form Metadata**|
|10372|**List**|
|10373|**Table Permission**|
|10374|**Page Template**|
|10375|**Poll Placement**|
|10376|**Power Pages Core Entity DS**|
|10377|**Publishing State**|
|10378|**Publishing State Transition Rule**|
|10379|**Redirect**|
|10380|**Shortcut**|
|10381|**Site Marker**|
|10382|**Site Setting**|
|10383|**Web File**|
|10384|**Multistep Form**|
|10385|**Multistep Form Metadata**|
|10386|**Form Step**|
|10387|**Web Link**|
|10388|**Web Link Set**|
|10389|**Web Page**|
|10390|**Web Page Access Control Rule**|
|10391|**Web Role**|
|10392|**Website**|
|10393|**Website Access**|
|10394|**Website Language**|
|10395|**Web Template**|
|10402|**Power Pages Scan Report**|
|10403|**Power Pages Log**|
|10404|**PowerPagesManagedIdentity**|
|10405|**Power Pages Site AI Feedback**|
|10410|**Catalog Submission Files**|
|10411|**Package Submission Store**|
|10412|**indexedtrait**|
|10413|**processor registration**|
|10414|**signal**|
|10415|**signal registration**|
|10416|**trait**|
|10417|**trait registration**|
|10418|**List Operation**|
|10419|**Marketing Form Display Attributes**|
|10420|**Database Version**|
|10421|**Upgrade Run**|
|10422|**Upgrade Step**|
|10423|**Upgrade Version**|
|10424|**Activity monitor**|
|10425|**Originating Queue Mapping**|
|10426|**Unified Routing Setup Tracker**|
|10427|**Available Times**|
|10428|**Available Times Data Source**|
|10429|**resource group data source**|
|10430|**Virtual Resource Group Resource**|
|10431|**Migration tracker**|
|10432|**Asset Category Template Association**|
|10433|**Asset Template Association**|
|10434|**Customer Asset**|
|10437|**Customer Asset Attachment**|
|10438|**Customer Asset Category**|
|10439|**Functional Location**|
|10440|**Functional Location Type**|
|10441|**Location Template Association**|
|10442|**Functional Location Type Template Association**|
|10443|**Property Definition**|
|10444|**Property Asset Association**|
|10445|**Property Location Association**|
|10446|**Property Log**|
|10447|**Property Template Association**|
|10448|**Template For Properties**|
|10449|**Warranty**|
|10456|**IoT Alert**|
|10457|**IoT Device**|
|10458|**IoT Device Category**|
|10459|**IoT Device Command**|
|10460|**IoT Device Command Definition**|
|10461|**IoT Device Data History**|
|10462|**IoT Device Property**|
|10463|**IoT Device Registration History**|
|10464|**IoT Device Visualization Configuration**|
|10465|**IoT Field Mapping**|
|10466|**IoT Property Definition**|
|10467|**IoT Provider**|
|10468|**IoT Provider Instance**|
|10469|**IoT Settings**|
|10472|**IoT Alert to Case Process**|
|10474|**Playbook Callable Context**|
|10475|**Playbook activity**|
|10476|**Playbook activity attribute**|
|10477|**[DEPRECATED] Playbook category**|
|10478|**Playbook**|
|10479|**[DEPRECATED] Playbook template**|
|10481|**admin_settings_entity**|
|10482|**Collab Space Team Association**|
|10483|**CRM Connection**|
|10484|**Derived insights related entity**|
|10485|**Entity derived insights**|
|10486|**External CRM**|
|10487|**External Record**|
|10488|**Lead Intelligence Insight**|
|10489|**Lead Intelligence Insight Entity Link**|
|10490|**msdyn_rawinsight**|
|10491|**msdyn_rawinsightentitylink**|
|10492|**Tagged Record**|
|10493|**Copilot for Sales customer list**|
|10494|**msdyn_vivaentitysetting**|
|10495|**msdyn_vivaorgextensioncred**|
|10496|**msdyn_vivaorgsetting**|
|10497|**msdyn_vivausersetting**|
|10498|**Activity Mapping**|
|10499|**Sales Copilot Email Insight**|
|10500|**Sales Copilot Insight**|
|10501|**Sales Copilot Insight Card State**|
|10502|**Sales Copilot Job Status**|
|10503|**Sales Copilot Knowledge Base**|
|10504|**Org level settings for Sales Copilot apps**|
|10505|**Sales Copilot User Setting**|
|10506|**App profile**|
|10507|**Application Extension**|
|10508|**Application Tab Template**|
|10509|**App profile role mapping**|
|10510|**Notification Field**|
|10511|**Notification Template**|
|10512|**Session Template**|
|10513|**Template Parameter**|
|10519|**Channel Integration Framework v1.0 Provider**|
|10520|**Notification Field (Deprecated)**|
|10521|**Notification Template (Deprecated)**|
|10522|**App Parameter Definition (Deprecated)**|
|10523|**Session Templates (Deprecated)**|
|10524|**Application Tab Template (Deprecated)**|
|10525|**Parameter (Deprecated)**|
|10526|**Template Tag (Deprecated)**|
|10527|**Application Type (Deprecated)**|
|10536|**Channel Integration Framework v2.0 Provider**|
|10538|**Conversation Data (Deprecated)**|
|10539|**KPI Event Data**|
|10540|**KPI Event Definition**|
|10541|**Session Data (Deprecated)**|
|10542|**Session Participant Data (Deprecated)**|
|10543|**Channel Definition**|
|10544|**Channel Definition Consent**|
|10545|**Channel Definition Locale**|
|10546|**Channel Instance**|
|10547|**Channel Instance Account**|
|10548|**Channel Message Attachment**|
|10549|**Channel Message Context Part**|
|10550|**Channel Message Part**|
|10551|**Consuming Application**|
|10552|**msdyn_DefExtendedChannelInstance**|
|10553|**msdyn_DefExtendedChannelInstanceAccount**|
|10554|**Productivity pane configuration**|
|10555|**Pane tab configuration**|
|10556|**Pane tool configuration**|
|10558|**Script**|
|10559|**Script step**|
|10561|**Action Input Parameter**|
|10562|**Action Output Parameter**|
|10563|**Macro Action Template**|
|10564|**Macro Solution Configuration**|
|10565|**Macro Connector**|
|10566|**Macro Run History**|
|10567|**Parameter definition**|
|10570|**Adaptive Card Configuration**|
|10571|**Smartassist configuration**|
|10573|**Read Tracker**|
|10574|**Read tracking enabled information**|
|10575|**Microsoft Teams Graph resource Entity**|
|10576|**msdyn_msteamssetting**|
|10577|**msdyn_msteamssettingsv2**|
|10578|**Microsoft Teams Collaboration entity**|
|10579|**Teams Dialer Admin settings**|
|10580|**Teams Contact Suggestion by AI**|
|10581|**Contact suggestion rule**|
|10582|**Contact suggestion ruleset**|
|10583|**Microsoft Teams chat association entity**|
|10584|**Microsoft Teams chat suggestion**|
|10585|**Microsoft Orgchart node entity**|
|10586|**Forecast Manual Adjustment History**|
|10587|**Distributed Lock**|
|10588|**Entity Delta Change**|
|10589|**File Upload Status Tracker**|
|10590|**Forecast**|
|10591|**Forecast Configuration**|
|10592|**Forecast definition**|
|10593|**Forecasting Cache**|
|10594|**Forecast Insights**|
|10595|**Forecast**|
|10596|**Forecast Prediction Data**|
|10597|**Forecast Prediction Status**|
|10598|**Forecast recurrence**|
|10599|**Recompute Tracker**|
|10600|**Forecast Recurrence**|
|10601|**ShareAs Configuration**|
|10602|**Customer email communication**|
|10603|**GDPRData**|
|10604|**ODOSFeatureMetadata**|
|10605|**ODOSMetadata**|
|10606|**Recurring Sales Action**|
|10607|**Recurring Sales Action V2**|
|10608|**msdyn_relationshipinsightsunifiedconfig**|
|10609|**siconfig**|
|10610|**SI Key Value Config**|
|10611|**Usage Metric**|
|10612|**Action Card Regarding**|
|10613|**Action Card Role Setting**|
|10614|**EntityRankingRule**|
|10615|**flowcardtype**|
|10616|**salesinsightssettings**|
|10617|**Action Card Usage**|
|10618|**Action Card Usage Aggregation**|
|10619|**Auto Capture Rule**|
|10620|**Auto Capture Settings**|
|10621|**UntrackedAppointment**|
|10622|**Suggested Activity**|
|10623|**Suggested Activity Data Source**|
|10624|**Suggested Contact**|
|10625|**Suggested Contacts Data Source**|
|10626|**Notes analysis Config**|
|10627|**icebreakersconfig**|
|10628|**dealmanageraccess**|
|10629|**Deal manager settings**|
|10630|**Account KPI Item**|
|10631|**Activity Analysis CleanUp State**|
|10632|**Relationship Analytics Config**|
|10633|**Contact KPI Item**|
|10634|**Daily Kpis for account**|
|10635|**Daily kpis for contact**|
|10636|**Daily kpis for lead**|
|10637|**Daily kpis for Opportunity**|
|10638|**Lead KPI Item**|
|10639|**Most Contacted**|
|10640|**Most Contacted By**|
|10641|**Opportunity KPI Item**|
|10642|**Relationship Analytics Metadata**|
|10643|**Similar entities feature importance**|
|10644|**wkwcolleaguesforcompany**|
|10645|**wkwcolleaguesforcontact**|
|10646|**wkwconfig**|
|10647|**Attribute Influence Statistics**|
|10648|**Prediction Computation Operation**|
|10649|**Prediction Model Status**|
|10650|**Prediction Scheduled Operation**|
|10651|**Predictive Model Score**|
|10652|**Predictive Score**|
|10653|**Predictive Scoring Sync Status**|
|10654|**Real Time Scoring**|
|10655|**Real Time Scoring Operation**|
|10656|**Submodel Definition**|
|10657|**Time spent in BPF**|
|10658|**Training Result**|
|10659|**OpportunityModelConfig**|
|10660|**LeadModelConfig**|
|10661|**ModelPreviewStatus**|
|10662|**Profile Album**|
|10663|**Post Configuration**|
|10664|**Post Rule Configuration**|
|10665|**Wall View**|
|10666|**Filter**|
|10667|**Customer Voice alert**|
|10668|**Customer Voice alert rule**|
|10669|**Customer Voice survey email template**|
|10670|**Customer Voice file response**|
|10671|**Customer Voice localized survey email template**|
|10672|**Customer Voice project**|
|10673|**Customer Voice survey question**|
|10674|**Customer Voice survey question response**|
|10675|**Customer Voice satisfaction metric**|
|10676|**Customer Voice survey**|
|10677|**Customer Voice survey invite**|
|10678|**Customer Voice survey reminder**|
|10679|**Customer Voice survey response**|
|10680|**Customer Voice unsubscribed recipient**|
|10681|**Customer Service Key Value Configuration**|
|10682|**AddToCalendar style**|
|10683|**basestyle**|
|10684|**Button style**|
|10685|**Code style**|
|10686|**Column style**|
|10687|**Content Block**|
|10688|**Divider style**|
|10689|**General styles**|
|10690|**imagestyle**|
|10691|**Layout Style**|
|10692|**QR code style**|
|10693|**Text style**|
|10694|**Video style**|
|10695|**App state**|
|10696|**CSAdminConfig**|
|10697|**Product Map**|
|10698|**Custom API Ruleset Configuration**|
|10699|**Decision contract**|
|10700|**Decision rule set**|
|10701|**Rulesetentitymapping**|
|10702|**Routing diagnostic item**|
|10703|**Routing diagnostic**|
|10704|**Template Context Variable**|
|10705|**Template Rule Set**|
|10706|**Template Variable Batch Operation**|
|10708|**Inbox card configuration**|
|10709|**Inbox Configuration**|
|10710|**Inbox Entity Configuration**|
|10711|**Inbox Personalized Configuration**|
|10712|**App Profile Copilot Configuration**|
|10713|**Swarm**|
|10714|**Swarm participant**|
|10715|**Swarm participant rule**|
|10716|**Swarm role**|
|10717|**Swarm skill**|
|10718|**Swarm template**|
|10719|**Autonomous case creation and update rules**|
|10720|**CHT App Profile Configuration**|
|10721|**Entity Attachment**|
|10722|**Time Tracker**|
|10723|**Customer feedback survey**|
|10724|**Customer feedback survey invite**|
|10725|**Customer feedback survey response**|
|10726|**msdyn_surveyconfig**|
|10727|**Survey setting**|
|10728|**Entity Attribute Prediction Rule**|
|10729|**Email Sentiment**|
|10730|**Master Entity Routing Configuration**|
|10731|**Routing Rule Set Setting**|
|10732|**Assignment Configuration**|
|10733|**Assignment Configuration Step**|
|10734|**Capacity Profile**|
|10735|**Last Agent**|
|10736|**Overflow Action Config**|
|10737|**Preferred Agent**|
|10738|**Preferred Agent Customer Identity**|
|10739|**Preferred Agent Routed Entity**|
|10740|**Routing configuration**|
|10741|**Routing configuration step**|
|10742|**Custom messaging account**|
|10743|**Channel Configuration**|
|10744|**Channel State Configuration**|
|10745|**Provisioning State**|
|10746|**AdminAppState**|
|10747|**Agent Status history**|
|10748|**Power BI Configuration**|
|10749|**Authentication Settings**|
|10750|**Auth Settings Entry**|
|10751|**Quick reply**|
|10752|**Entity Routing Context**|
|10753|**Channel Capability**|
|10754|**Conversation Action**|
|10755|**Conversation Action Locale**|
|10756|**Conversation Message Block**|
|10757|**DeletedConversation**|
|10758|**Deprecated Workstream Entity Configuration**|
|10759|**Entity**|
|10760|**Ongoing conversation (Deprecated)**|
|10761|**Live work item event**|
|10762|**Work Stream**|
|10763|**Masking Rule**|
|10764|**Auto block rule**|
|10765|**Bot Channel Registration Secret**|
|10766|**Omnichannel channel api conversation privilege**|
|10767|**Omnichannel channel api message privilege**|
|10768|**Channel api method mapping**|
|10769|**External context**|
|10770|**Flagged spam**|
|10771|**Language**|
|10772|**Conversation**|
|10775|**Context item value**|
|10776|**Live Work Item Participant (Deprecated)**|
|10777|**Conversation Sentiment**|
|10778|**Context variable**|
|10779|**Localization**|
|10780|**OC Payment Profile**|
|10781|**Recording**|
|10782|**Omnichannel Request**|
|10783|**Rich message**|
|10784|**Rich object map**|
|10785|**Rule Item**|
|10786|**Sentiment daily topic**|
|10787|**Sentiment daily topic keyword**|
|10788|**Sentiment daily topic trending**|
|10789|**Session**|
|10790|**Session Participant Event**|
|10791|**Session Sentiment**|
|10792|**Message**|
|10793|**Tag**|
|10794|**Geo Location Provider**|
|10795|**Omnichannel Configuration**|
|10796|**Omnichannel Personalization**|
|10797|**Omnichannel Queue (Deprecated)**|
|10798|**Omnichannel Sync Config**|
|10799|**Operating Hour**|
|10800|**Personal quick reply**|
|10801|**Personal sound setting**|
|10802|**Persona Security Role Mapping**|
|10803|**Presence**|
|10804|**Provider**|
|10805|**RoutingRequest**|
|10806|**Search Configuration**|
|10807|**Sentiment analysis**|
|10808|**Session event**|
|10809|**Session participant**|
|10810|**Audio File**|
|10811|**Sound notification setting**|
|10812|**Transcript**|
|10813|**UR notification template**|
|10814|**UR Notification Template Mapping**|
|10815|**User settings**|
|10816|**Self service**|
|10823|**Agent capacity update history**|
|10824|**Bookable Resource Capacity Profile**|
|10825|**Work stream capacity profile**|
|10826|**Conversation Capacity profile**|
|10827|**Agent Capacity Profile Unit**|
|10828|**Agent Channel State**|
|10829|**Agent Status**|
|10830|**Agent Group**|
|10831|**Agent Group Language**|
|10832|**Agent Group Matching Criteria**|
|10833|**Agent Group Membership**|
|10834|**Agent Group Region**|
|10835|**Agent Language**|
|10836|**Agent Matching Criteria**|
|10837|**Agent Region**|
|10838|**Language Hierarchy**|
|10839|**Matching Criteria**|
|10840|**Conversation Matching Criteria**|
|10841|**Region**|
|10842|**Conversation Characteristic**|
|10843|**Session Characteristic**|
|10844|**Skill Attachment Rule**|
|10845|**Attach Skill**|
|10846|**Model training details**|
|10847|**Training data import configuration**|
|10848|**Characteristic mapping**|
|10849|**Training record**|
|10850|**Skill finder model**|
|10851|**Effort estimate**|
|10852|**Effort estimation model**|
|10853|**Effort model training details**|
|10854|**ConversationInsight**|
|10855|**Active ICD Extension**|
|10856|**Entity-Workstream Map**|
|10857|**ICD Extension**|
|10858|**Lock Status**|
|10859|**Omnichannel agent assignment custom api privilege**|
|10860|**Conversation Action Item**|
|10861|**Conversation Aggregated Insights**|
|10862|**Comment**|
|10863|**Conversation Participant Insights**|
|10864|**Conversation Participant Sentiment**|
|10865|**Conversation Question**|
|10866|**Conversation Segment Sentiment**|
|10867|**Conversation Sentiment**|
|10868|**Conversation Signal**|
|10869|**Conversation Subject**|
|10870|**Conversation Summary Suggestion**|
|10871|**Conversation System Tag**|
|10872|**Conversation Tag**|
|10873|**Recording (Deprecated)**|
|10874|**SCI Conversation**|
|10875|**Custom Email Highlight**|
|10876|**Custom Highlight**|
|10877|**Custom Publisher**|
|10878|**EnvironmentSettings**|
|10879|**UserSettings**|
|10880|**CatalogEventStatusConfiguration**|
|10881|**Configuration**|
|10882|**Trigger**|
|10883|**Triggers To Sdk Message Processing Steps**|
|10884|**EventParameterMetadata**|
|10885|**TrackingContext**|
|10886|**Marketing feature configuration**|
|10887|**msdynmkt_experimentv2**|
|10888|**ACS channel instance**|
|10889|**ACS channel instance account**|
|10890|**Infobip channel instance**|
|10891|**Infobip channel instance account**|
|10892|**Link mobility channel instance**|
|10893|**Link mobility channel instance account**|
|10894|**MockSmsProvider channel instance**|
|10895|**MockSmsProvider channel instance account**|
|10896|**TeleSign channel instance**|
|10897|**TeleSign channel instance account**|
|10898|**Twilio channel instance**|
|10899|**Twilio channel instance account**|
|10900|**Vibes channel instance**|
|10901|**Vibes channel instance account**|
|10902|**Predefined Placeholder**|
|10903|**Metadata Entity Relationship**|
|10904|**Metadata Item**|
|10905|**Metadata Store State**|
|10906|**DigitalSellingActiveTask**|
|10907|**DigitalSellingCompletedTask**|
|10908|**Sales Tag**|
|10909|**Sequence**|
|10910|**Sequence Stat**|
|10911|**Sequence Target**|
|10912|**Sequence Target Step**|
|10913|**Sequence Template**|
|10915|**sabackupdiagnostic**|
|10916|**SABatchRunInstance**|
|10917|**salesroutingdiagnostic**|
|10918|**SARunInstance**|
|10919|**Segment**|
|10920|**segmentsetting**|
|10921|**Segment property**|
|10922|**SegmentsUtil**|
|10923|**Assignment Rule**|
|10924|**Seller attribute**|
|10925|**Seller attribute value**|
|10926|**Assignment Map**|
|10927|**Sales Assignment Setting**|
|10928|**Sales routing run**|
|10930|**Extended User Setting**|
|10931|**Sales acceleration insights**|
|10932|**Sales Acceleration settings**|
|10933|**Insight**|
|10934|**Work List Suggestion**|
|10935|**Work list suggestion source**|
|10936|**Work List View Configuration**|
|10937|**Work Queue Record**|
|10938|**Work Queue Record State**|
|10939|**Work list user setting**|
|10940|**WQDataSource**|
|10941|**Suggestion Assignment Rule**|
|10942|**Suggestion Principal Object Access**|
|10943|**Suggestion Seller Priority**|
|10944|**Data Hygiene Setting Info**|
|10945|**Duplicate Detection Plugin Run**|
|10946|**Duplicate Lead Mapping**|
|10947|**Lead Hygiene Setting**|
|10948|**Linked Entity Attribute Validity**|
|10949|**Sales provisioning request**|
|10950|**SalesOmnichannel Message**|
|10951|**Text message template**|
|10952|**Data Analytics Admin Settings (Deprecated)**|
|10953|**Data Analytics Report**|
|10954|**Insights**|
|10955|**Sales acceleration reports**|
|10957|**Bot Session**|
|10958|**Automated action rule**|
|10959|**Automated action rules mapping**|
|10960|**Conversation disposition code map**|
|10961|**Live Conversation Counter Condition**|
|10962|**OC Disposition Code**|
|10963|**Work Stream Bot Mapping**|
|10964|**Representative Copilot Setting**|
|10965|**Copilot Summarization Setting**|
|10966|**intent**|
|10967|**intentattribute**|
|10968|**intentattributeset**|
|10969|**intentattribute_entity**|
|10970|**Intent Config**|
|10971|**intententity**|
|10972|**LOB Backfill Status**|
|10973|**Line of Business**|
|10974|**msdyn_intentfamily_harvestingconfiguration**|
|10975|**msdyn_intentfeature_configuration**|
|10976|**Intent Group Condition**|
|10977|**msdyn_intentharvesting_batchjobstatus**|
|10978|**msdyn_intentharvesting_batchjobstatusdetail**|
|10979|**msdyn_intentharvesting_provisioning_status**|
|10980|**Intent Solution Map**|
|10981|**msdyn_intentsolution_mappingconfiguration**|
|10982|**Case Enrichment**|
|10983|**Case follow up and closure configuration**|
|10984|**Case sentiment settings**|
|10985|**Case Suggestion**|
|10986|**Case Suggestion Request Payload**|
|10987|**Case Suggestions Data Souce**|
|10988|**User Preference For Copilot**|
|10989|**Copilot assisted case form fill settings**|
|10990|**Copilot Interaction**|
|10991|**Copilot Interaction Data**|
|10992|**Copilot knowledge interaction**|
|10993|**Copilot Transcript**|
|10994|**Copilot Transcript Data**|
|10995|**KB Enrichment**|
|10996|**Knowledge Article Suggestion**|
|10997|**Knowledge Article Suggestion Data Source**|
|10998|**Next Action**|
|10999|**Service Copilot Plugin**|
|11000|**Service Copilot Plugin Action**|
|11001|**Service Copilot Plugin Role**|
|11002|**Suggestion Interaction**|
|11003|**Suggestion request payload**|
|11004|**Suggestions Model Summary**|
|11005|**Suggestions Setting**|
|11006|**Case Management Agent for case closure Activity**|
|11007|**Case Management Agent for case closure Monitoring**|
|11008|**Data Analytics User Customized Report**|
|11009|**Data Analytics Dataset**|
|11010|**Data Analytics Workspace**|
|11011|**Report Bookmark**|
|11012|**Agent Resource Forecasting**|
|11013|**[Deprecated] Dynamics Customer Service Analytics**|
|11014|**Case Topic**|
|11015|**Case Topic Setting**|
|11016|**Case Topic Summary**|
|11017|**Case topic Incident mapping**|
|11018|**Customer Service historical analytics**|
|11019|**Email analytics**|
|11020|**Forecast**|
|11021|**Knowledge analytics**|
|11022|**Model Customization analytics**|
|11023|**UR RecordRouting Real-time Analytics**|
|11024|**Forecast Summary and Setting**|
|11025|**Keywords Description Suggestion Setting**|
|11026|**Conversation Summary Interaction**|
|11027|**Conversation Summary Setting**|
|11028|**Conversation Topic**|
|11029|**Conversation Topic Setting**|
|11030|**Conversation Topic Summary**|
|11031|**Conversation topic Conversation mapping**|
|11032|**Omnichannel historical analytics**|
|11033|**Omnichannel voice historical analytics (preview) (Deprecated)**|
|11034|**Omnichannel Realtime analytics**|
|11035|**Copilot Analytics**|
|11081|**Actual**|
|11082|**Booking Setup Metadata**|
|11083|**Requirement Organization Unit**|
|11084|**Client Extension**|
|11085|**Requirement Characteristic**|
|11086|**Requirement Group**|
|11087|**Bookable Resource Association**|
|11088|**Configuration**|
|11089|**Booking Alert**|
|11090|**Booking Alert Status**|
|11091|**Booking Change**|
|11092|**Booking Rule**|
|11093|**Business Closure**|
|11094|**Organizational Unit**|
|11095|**Priority**|
|11096|**Requirement Relationship**|
|11097|**Requirement Resource Category**|
|11098|**Requirement Resource Preference**|
|11099|**Requirement Status**|
|11100|**Resource Requirement**|
|11101|**Resource Requirement Detail**|
|11102|**Resource Territory**|
|11103|**Schedule Board Setting**|
|11104|**Scheduling Parameter**|
|11105|**System User Scheduler Setting**|
|11106|**Fulfillment Preference**|
|11107|**Time Group Detail**|
|11108|**Transaction Origin**|
|11109|**Work Template**|
|11110|**Optimization Request**|
|11111|**Requirement Change**|
|11112|**Requirement Dependency**|
|11113|**Scheduling Feature Flag**|
|11114|**Scheduling Scope**|
|11115|**channel**|
|11116|**Scenario**|
|11117|**Azure notification hub**|
|11118|**Channel instance secret**|
|11119|**Survey Answer Option**|
|11120|**Survey Response**|
|11121|**Survey Response Value**|
|11122|**Chat Widget Language(deprecated)**|
|11123|**Chat Widget**|
|11124|**Live Chat Context**|
|11125|**Chat Widget Location**|
|11126|**Localized Survey Question (Deprecated)**|
|11127|**Survey Question Sequence**|
|11128|**Survey Question**|
|11129|**Web Engagement Ruleset**|
|11130|**Web Engagement Ruleset Config**|
|11131|**Web Engagement Ruleset Revision**|
|11132|**Web Engagement Site Area**|
|11133|**Communication Provider Setting**|
|11134|**Communication Provider Setting Entry**|
|11135|**Phone Number**|
|11136|**Carrier**|
|11137|**SMS Number settings**|
|11138|**SMS Engagement Context**|
|11139|**SMS Number**|
|11140|**SMS Setting Secret**|
|11141|**Facebook Engagement Context**|
|11142|**Facebook Application**|
|11143|**Facebook Page**|
|11144|**Custom Messaging Engagement Context**|
|11145|**LINE Engagement Context**|
|11146|**Custom messaging channel**|
|11147|**LINE account**|
|11148|**Twitter account**|
|11149|**Twitter handle**|
|11150|**WeChat account**|
|11151|**WhatsApp account**|
|11152|**WhatsApp number**|
|11153|**Twitter Engagement Context**|
|11154|**WeChat Engagement Context**|
|11155|**WhatsApp Engagement Context**|
|11156|**Apple messages for business account**|
|11157|**Apple messages for business engagement context**|
|11158|**OC Apple Pay Entity**|
|11159|**Google's Business Messages agent account**|
|11160|**Google's Business Messages partner account**|
|11161|**Google's Business Messages engagement context**|
|11162|**Twitter Handle Provisioning Status**|
|11163|**OC Twitter Handle Secret**|
|11164|**Microsoft Teams account**|
|11165|**(Deprecated)Teams Engagement Context**|
|11166|**Teams Engagement Context**|
|11167|**Outbound Configuration**|
|11168|**Outbound message**|
|11169|**Adaptation Build**|
|11170|**Adaptation Model**|
|11171|**Adaptation Profile**|
|11172|**Adaptation Profile Settings**|
|11173|**Adaptation Tag**|

## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_bookingalert_sla_slaid](#BKMK_msdyn_bookingalert_sla_slaid)
- [msdyn_bookingalert_sla_slainvokedid](#BKMK_msdyn_bookingalert_sla_slainvokedid)
- [msdyn_ocoutboundmessage_sla_slaid](#BKMK_msdyn_ocoutboundmessage_sla_slaid)
- [msdyn_ocoutboundmessage_sla_slainvokedid](#BKMK_msdyn_ocoutboundmessage_sla_slainvokedid)

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



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.sla?displayProperty=fullName>
