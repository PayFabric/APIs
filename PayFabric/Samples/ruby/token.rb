require 'rest_client'
require 'json'

module PayFabric

  module Token
    extend self
    # 
    # Return token key
    #
    def create(divece_id, password, sandbox) 
      authorization = "#{divece_id}|#{password}"
      url = if sandbox
          "https://sandbox.payfabric.com/rest/v1/api/token/create"
        else
          "https://payfabric.com/rest/v1/api/token/create"
        end
      response = RestClient.get(url, 
        :accept => :json, 
        :authorization => authorization,
        :accept => "application/json; charset=utf-8"
      )
     JSON.parse(response.body)['Token']
    end
  end

end
