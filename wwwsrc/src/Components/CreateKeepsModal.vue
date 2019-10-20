<template>
<div class="createKeeps"> 
  <button class="btn btn-success" data-toggle="modal" data-target="#createKeepsModal"> 
    Make a new Keep</button>
    <div id="CreateKeepsModal" class="modal" role="dialog"> 
      <div class="modal-dialog"> 
        <div class="modal-contrent"> 
          <div class="modal-header"> 
            <button type="button" class="close" data-dismiss="modal"></button> 
            <h4 class="modal-title">Create a Keep</h4>
          </div>
          <div class="modal-body"> 
            <form> 
              <div class="form-group"> 
                <label form="group name">Keep Name</label>
                <input type="text" class="form-control" id="keepname" placeholder="Keep Name"
                v-model="newKeep.name" /> 
              </div>
              <div class="form-group"> 
                <label for="group name">Keep Description</label>
                  <input type="text" class="form-control" id="keepdescription" placeholder="keep description"
                  v-model="newKeep.description" /> 
              </div> 
                  <div class="form-group"> 
                    <label for="group name">Keep image</label>
                    <input type="image" class="form-control" id="keepimage" placeholder="Keep image"
                    v-model="newKeep.img" /> 
                  <button type="submit" @click="createKeeps(user)" class="btn btn-primary">Sumit</button>
                  </div> 
             </form> 
        </div>
      </div>
    </div>
</div>
</template>

<script>
export default {
  name: "Keeps-Modal", 
  data() {
    return {
    newKeep: {
      name: "",
      description: "",
      img: "" 
    }
  };
  },
  computed: {
    user() {
      return this.$store.state.user; 
    }
  },
  methods: {
    createKeep(user) {
      this.$store.dispatch("createkeep", this.newKeep);
      this.newKeep = { name: "", description: "", img: "" };
    }
  },
  components: {}
};
</script>

<style scoped> 
.modal-content {
  background-color: blue; 
}

</style> 