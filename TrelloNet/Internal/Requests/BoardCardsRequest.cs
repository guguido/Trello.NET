using RestSharp;

namespace TrelloNet.Internal.Requests
{
	internal class BoardCardsRequest : BoardRequest
	{
		public BoardCardsRequest(string boardId, CardFilter filter)
			: base(boardId, "cards")
		{			
			AddParameter("labels", "true", ParameterType.GetOrPost);
			this.AddFilter(filter);
		}
	}
}