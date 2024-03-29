import Vue from 'vue'
import Vuex from 'vuex'
import Axios from 'axios'
import router from './router'
import AuthService from './AuthService'

Vue.use(Vuex)

let baseUrl = location.host.includes('localhost') ? '//localhost:5000/' : '/'

let api = Axios.create({
  baseURL: baseUrl + "api/",
  timeout: 3000,
  withCredentials: true
})

export default new Vuex.Store({
  state: {
    user: {},
    keep: {},
    keeps: [], 
    Vault: {}, 
    shares: {},
    views: {}, 


  },
  mutations: {
    setUser(state, user) {
      state.user = user
    },
    resetState(state) {
      //clear the entire state object of user data
      state.user = {}
    },
    setKeeps(state, payload) {
      state.keeps = payload
    }, 
    setVaults(state, payload) {
      state.Vault = payload
    },
  },

  actions: {
    async register({ commit, dispatch }, creds) {
      try {
        let user = await AuthService.Register(creds)
        commit('setUser', user)
        router.push({ name: "home" })
      } catch (e) {
        console.warn(e.message)
      }
    },
    async login({ commit, dispatch }, creds) {
      try {
        let user = await AuthService.Login(creds)
        commit('setUser', user)
        router.push({ name: "home" })
      } catch (e) {
        console.warn(e.message)
      }
    },
    async logout({ commit, dispatch }) {
      try {
        let success = await AuthService.Logout()
        if (!success) { }
        commit('resetState')
        router.push({ name: "login" })
      } catch (e) {
        console.warn(e.message)
      }
    }, 
    async getkeeps({ commit, dispatch }) {
      try { 
        let res = await api.get('keeps')
        commit('setKeeps', res.data)
      } catch (error) {
        console.error(error) 
      }
    }, 
    async getVaults({ commit, dispatch }) {
      try {
        let res = await api.get('vaults')
        commit('setVaults', res.data)
      } catch (error) {
        console.error(error) 
      }
    }, 
    async createKeep({ dispatch }, payload) {
      try {
        let res = await api.post('/keeps', payload)
        dispatch('getKeeps')
      } catch (error) {
        console.error(error)
      }
    }, 
    async createVault({ dispatch }, payload) { 
      try {
        let res = await api.post('/Vaults', payload)
        dispatch('getVaults')
      } catch (error) {
        console.error(error) 
      }
    },
    async editKeeep({ dispatch }, payload) {
      try {
        let res = await api.put('/keeps', payload) 
        dispatch('getKeeps') 
      } catch (error) {
        console.error(error) 
      }
    },
    async editVault({ dispatch }, payload) {
      try {
        let res = await api.put('/Vaults', payload) 
        dispatch('getVaults') 
      } catch (error) {
        console.error(error)
      }
    },
    async deleteKeep({ dispatch }, payload) {
      try {
        let res = await api.delete('/keeps', payload) 
        dispatch('getKeeps')
      } catch (error) {
        console.error(error) 
      }
    }, 
    async deleteVault({ dispatch }, payload) {
      try {
        let res = await api.delete('/Vaults', payload)
        dispatch('getVaults')
      } catch (error) {
        console.error(error) 
      }
    }
  }
})
