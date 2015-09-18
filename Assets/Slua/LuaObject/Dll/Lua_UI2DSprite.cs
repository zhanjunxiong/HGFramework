﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UI2DSprite : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UI2DSprite o;
			o=new UI2DSprite();
			pushValue(l,o);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MakePixelPerfect(IntPtr l) {
		try {
			UI2DSprite self=(UI2DSprite)checkSelf(l);
			self.MakePixelPerfect();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnFill(IntPtr l) {
		try {
			UI2DSprite self=(UI2DSprite)checkSelf(l);
			BetterList<UnityEngine.Vector3> a1;
			checkType(l,2,out a1);
			BetterList<UnityEngine.Vector2> a2;
			checkType(l,3,out a2);
			BetterList<UnityEngine.Color32> a3;
			checkType(l,4,out a3);
			self.OnFill(a1,a2,a3);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_nextSprite(IntPtr l) {
		try {
			UI2DSprite self=(UI2DSprite)checkSelf(l);
			pushValue(l,self.nextSprite);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_nextSprite(IntPtr l) {
		try {
			UI2DSprite self=(UI2DSprite)checkSelf(l);
			UnityEngine.Sprite v;
			checkType(l,2,out v);
			self.nextSprite=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sprite2D(IntPtr l) {
		try {
			UI2DSprite self=(UI2DSprite)checkSelf(l);
			pushValue(l,self.sprite2D);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sprite2D(IntPtr l) {
		try {
			UI2DSprite self=(UI2DSprite)checkSelf(l);
			UnityEngine.Sprite v;
			checkType(l,2,out v);
			self.sprite2D=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_material(IntPtr l) {
		try {
			UI2DSprite self=(UI2DSprite)checkSelf(l);
			pushValue(l,self.material);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_material(IntPtr l) {
		try {
			UI2DSprite self=(UI2DSprite)checkSelf(l);
			UnityEngine.Material v;
			checkType(l,2,out v);
			self.material=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shader(IntPtr l) {
		try {
			UI2DSprite self=(UI2DSprite)checkSelf(l);
			pushValue(l,self.shader);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shader(IntPtr l) {
		try {
			UI2DSprite self=(UI2DSprite)checkSelf(l);
			UnityEngine.Shader v;
			checkType(l,2,out v);
			self.shader=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mainTexture(IntPtr l) {
		try {
			UI2DSprite self=(UI2DSprite)checkSelf(l);
			pushValue(l,self.mainTexture);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_premultipliedAlpha(IntPtr l) {
		try {
			UI2DSprite self=(UI2DSprite)checkSelf(l);
			pushValue(l,self.premultipliedAlpha);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pixelSize(IntPtr l) {
		try {
			UI2DSprite self=(UI2DSprite)checkSelf(l);
			pushValue(l,self.pixelSize);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_drawingDimensions(IntPtr l) {
		try {
			UI2DSprite self=(UI2DSprite)checkSelf(l);
			pushValue(l,self.drawingDimensions);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_border(IntPtr l) {
		try {
			UI2DSprite self=(UI2DSprite)checkSelf(l);
			pushValue(l,self.border);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_border(IntPtr l) {
		try {
			UI2DSprite self=(UI2DSprite)checkSelf(l);
			UnityEngine.Vector4 v;
			checkType(l,2,out v);
			self.border=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UI2DSprite");
		addMember(l,MakePixelPerfect);
		addMember(l,OnFill);
		addMember(l,"nextSprite",get_nextSprite,set_nextSprite,true);
		addMember(l,"sprite2D",get_sprite2D,set_sprite2D,true);
		addMember(l,"material",get_material,set_material,true);
		addMember(l,"shader",get_shader,set_shader,true);
		addMember(l,"mainTexture",get_mainTexture,null,true);
		addMember(l,"premultipliedAlpha",get_premultipliedAlpha,null,true);
		addMember(l,"pixelSize",get_pixelSize,null,true);
		addMember(l,"drawingDimensions",get_drawingDimensions,null,true);
		addMember(l,"border",get_border,set_border,true);
		createTypeMetatable(l,constructor, typeof(UI2DSprite),typeof(UIBasicSprite));
	}
}