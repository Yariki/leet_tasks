package com.fruitfactory.subsets.subsets;
import org.junit.Test;

import java.util.List;

import static org.junit.Assert.*;

public class SubsetsTests {

	@Test
	public void NullTest_ShouldSuccessed(){
		Subsets subsets = new Subsets(null);
		List<List<Integer>> result = subsets.findSubsets();

		assertNull(result);
	}

	@Test
	public void FirstAttempt_Successed(){
		Subsets subsets =  new Subsets(new int[]{1,5});
		List<List<Integer>> result = subsets.findSubsets();

		assertNotNull(result);
		assertEquals(4, result.size());
		assertTrue(result.get(0).isEmpty());
		assertEquals(1,(int)result.get(1).get(0));
		assertEquals(5,(int)result.get(2).get(0));
		assertEquals(1, (int)result.get(3).get(0));
		assertEquals(5,(int)result.get(3).get(1));
	}

	@Test
	public void SecondAttempt_Successed(){
		Subsets subsets =  new Subsets(new int[]{1,5,3});
		List<List<Integer>> result = subsets.findSubsets();

		assertNotNull(result);
		assertEquals(8, result.size());
		assertTrue(result.get(0).isEmpty());
		assertEquals(1,(int)result.get(1).get(0));
		assertEquals(5,(int)result.get(2).get(0));
		assertEquals(1, (int)result.get(3).get(0));
		assertEquals(5,(int)result.get(3).get(1));
		assertEquals(3, (int)result.get(4).get(0));
		assertEquals(1, (int)result.get(5).get(0));
		assertEquals(3,(int)result.get(5).get(1));
		assertEquals(5, (int)result.get(6).get(0));
		assertEquals(3, (int)result.get(6).get(1));
		assertEquals(1,(int)result.get(7).get(0));
		assertEquals(5,(int)result.get(7).get(1));
		assertEquals(3,(int)result.get(7).get(2));
	}



}
