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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Model.V20141111
{
	public class DescribeLiveStreamOnlineUserNumByDomainResponse : AcsResponse
	{

		private string requestId;

		private long? totalUserNumber;

		private long? count;

		private long? pageNumber;

		private long? pageSize;

		private List<DescribeLiveStreamOnlineUserNumByDomain_LiveStreamOnlineUserNumInfo> onlineUserInfo;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public long? TotalUserNumber
		{
			get
			{
				return totalUserNumber;
			}
			set	
			{
				totalUserNumber = value;
			}
		}

		public long? Count
		{
			get
			{
				return count;
			}
			set	
			{
				count = value;
			}
		}

		public long? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public long? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public List<DescribeLiveStreamOnlineUserNumByDomain_LiveStreamOnlineUserNumInfo> OnlineUserInfo
		{
			get
			{
				return onlineUserInfo;
			}
			set	
			{
				onlineUserInfo = value;
			}
		}

		public class DescribeLiveStreamOnlineUserNumByDomain_LiveStreamOnlineUserNumInfo
		{

			private string streamUrl;

			private long? userNumber;

			private string time;

			public string StreamUrl
			{
				get
				{
					return streamUrl;
				}
				set	
				{
					streamUrl = value;
				}
			}

			public long? UserNumber
			{
				get
				{
					return userNumber;
				}
				set	
				{
					userNumber = value;
				}
			}

			public string Time
			{
				get
				{
					return time;
				}
				set	
				{
					time = value;
				}
			}
		}
	}
}