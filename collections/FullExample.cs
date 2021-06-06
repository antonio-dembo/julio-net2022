using System.Collections;
using System.Collections.Generic;

namespace collections
{
  public class FormattedAddress : IEnumerable<string>
  {
    private List<string> internalList = new List<string>();
    public IEnumerator<string> GetEnumerator() => internalList.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => internalList.GetEnumerator();

    public void Add (string firstname, string lastname, string street,
      string city, string state, string zipcode) => internalList.Add(
        $@"{firstname} {lastname} {street} {city},
          {state} {zipcode}");
  }

}