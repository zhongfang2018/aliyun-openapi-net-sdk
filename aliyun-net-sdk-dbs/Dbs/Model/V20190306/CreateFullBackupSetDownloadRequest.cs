/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Dbs.Transform;
using Aliyun.Acs.Dbs.Transform.V20190306;

namespace Aliyun.Acs.Dbs.Model.V20190306
{
    public class CreateFullBackupSetDownloadRequest : RpcAcsRequest<CreateFullBackupSetDownloadResponse>
    {
        public CreateFullBackupSetDownloadRequest()
            : base("Dbs", "2019-03-06", "CreateFullBackupSetDownload", "cbs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string clientToken;

		private string backupSetId;

		private string ownerId;

		private string backupSetDataFormat;

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string BackupSetId
		{
			get
			{
				return backupSetId;
			}
			set	
			{
				backupSetId = value;
				DictionaryUtil.Add(QueryParameters, "BackupSetId", value);
			}
		}

		public string OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value);
			}
		}

		public string BackupSetDataFormat
		{
			get
			{
				return backupSetDataFormat;
			}
			set	
			{
				backupSetDataFormat = value;
				DictionaryUtil.Add(QueryParameters, "BackupSetDataFormat", value);
			}
		}

        public override CreateFullBackupSetDownloadResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateFullBackupSetDownloadResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
