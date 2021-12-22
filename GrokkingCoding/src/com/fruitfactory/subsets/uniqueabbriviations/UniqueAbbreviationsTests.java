package com.fruitfactory.subsets.uniqueabbriviations;
import org.junit.Test;

import java.util.List;

import static org.junit.Assert.*;
public class UniqueAbbreviationsTests {

	@Test
	public void Null_Success(){
		UniqueAbbreviations abbr = new UniqueAbbreviations(null);
		List<String> result = abbr.findGeneralizedAbbreviations();

		assertNull(result);
	}
	@Test
	public void First_Attempt_Success(){
		UniqueAbbreviations abbr = new UniqueAbbreviations("BAT");
		List<String> result = abbr.findGeneralizedAbbreviations();

		assertNotNull(result);
		assertTrue(result.size() > 0);

		assertEquals("3", result.get(0));
		assertEquals("BAT", result.get(result.size() - 1));
	}
}
