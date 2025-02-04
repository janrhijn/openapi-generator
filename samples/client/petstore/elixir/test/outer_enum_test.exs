defmodule OuterEnumTest do
  use ExUnit.Case, async: true

  alias OpenapiPetstore.Deserializer
  alias OpenapiPetstore.Model.EnumTest

  @valid_json """
  {
    "enum_string": "UPPER",
    "outerEnum": "placed"
  }
  """

  @tag timeout: :infinity
  test "jason_decode/2 with valid JSON" do
    assert Deserializer.jason_decode(@valid_json, EnumTest) ==
             {:ok,
              %EnumTest{
                enum_string: "UPPER",
                outerEnum: "placed"
              }}
  end
end
